using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;
using TwitchLib.PubSub;
using TwitchLib.PubSub.Events;
using System.Text;
using TwitchLib.Communication.Events;
using static System.Net.Mime.MediaTypeNames;

namespace SimpleTwitchTTS
{
    internal class TwitchBot
    {
        
        string TwitchNick;
        ConnectionCredentials Creds;
        TwitchClient TClient;
        TwitchPubSub TPubSub = new TwitchPubSub();
        bool TtsClearEmoji = false;

        List<string> BlackList = new List<string>();
        List<string> WhatToReplace = new List<string>();
        List<string> WhatToSubstitude = new List<string>();
        string TwitchApi;
        string TwitchClientId;

        string AnecdotChannelPoints;
        string AnecdotChatCommand;
        string anecdotUrl = "http://rzhunemogu.ru/RandJSON.aspx?CType=1";

        System.Windows.Forms.Timer timer;
        List<mutedUsersForTime> mutedUsersForTimeList = new List<mutedUsersForTime>();

        TimeSpan intervalForMutedUsers = new TimeSpan(0, MutedForTimeMinutes, 0); // время жизни строки текста: (часы, минуты, секунды)

        //TClient needed to change connection status.
        internal TwitchClient? Connect(string Api, string Nick, string ClientId, string VoiceName, TwitchClient client, string AnecdotChatCommand, string AnecdotChannelPoints, string AnecdotsFromFilesChatCommand, string AnecdotsFromFilesChannelPoints)
        {

            try
            {
                if (client != null)
                {
                    this.AnecdotsFromFilesCommand = AnecdotsFromFilesChatCommand;
                    this.AnecdotsFromFileChannelPoint = AnecdotsFromFilesChannelPoints;
                    this.AnecdotChatCommand = AnecdotChannelPoints;
                    this.AnecdotChatCommand = AnecdotChatCommand;
                    TwitchApi = Api;
                    TwitchClientId = ClientId;
                    TClient = client;
                    Creds = new ConnectionCredentials(Nick, Api);
                    TwitchNick = Nick;
                    SynthText.SelectVoice(VoiceName);
                    TClient.Initialize(Creds, Nick);
                    TClient.OnConnected += TClientOnConnected;
                    TClient.OnMessageReceived += TClientOnMessageReceived;
                    TClient.OnChatCommandReceived += TClientOnChatCommandReceived;
                    TClient.OnDisconnected += TClientOnDisconnected;
                    TClient.Connect();
                    TPubSub.OnPubSubServiceConnected += TPubSubServiceConnected;
                    TPubSub.OnChannelPointsRewardRedeemed += TPubSubChannelPointsRewardRedeemed;
                    TPubSub.Connect();

                    timer = new System.Windows.Forms.Timer();
                    timer.Interval = 1000; // проверка 1 раз в секунду
                    timer.Tick += Timer_Tick;
                    timer.Start();

                    return TClient;
                }
                else { return null; }
            }
            catch
            {
                return null;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            for (int i = mutedUsersForTimeList.Count - 1; i >= 0; i--)
            {
                if (mutedUsersForTimeList[i].Time + intervalForMutedUsers.Add(TimeSpan.FromMinutes(MutedForTimeMinutes)) < DateTime.Now) // если время истекло
                {
                    mutedUsersForTimeList.RemoveAt(i); // удаляем текущую запись строки
                }
            }
        }

        private struct mutedUsersForTime
        {
            public string Str;
            public DateTime Time;
        }


        private void TClientOnDisconnected(object? sender, OnDisconnectedEventArgs e)
        {
            try
            {// либо у тебя руки из жопы либо эта шняга не работает
             // спойлер это вина разраба. При дисконнекте эта шляпа ВЕЧНО вызывается!
                //TClient.Reconnect();
            }
            catch { }

        }

        private void TPubSubServiceConnected(object? sender, EventArgs e)
        {
            //06.10.2023 18:02 да в пизду оно опять не работает
            //05/12/2023 04:24 да в пизду оно опять    работает
            TPubSub.ListenToChannelPoints(TwitchClientId);
            //if user gives api with NO FULL ACESS
            //then this part of the code will execute approximately every 3 minutes
            TPubSub.SendTopics(TwitchApi, false);
        }

        string MutedUserName;
        private async void TPubSubChannelPointsRewardRedeemed(object? sender, OnChannelPointsRewardRedeemedArgs e)
        {
            if (e.RewardRedeemed.Redemption.UserInput == AnecdotChatCommand && !BlackList.Contains(e.RewardRedeemed.Redemption.User.DisplayName.ToLower()))
            {
                if (e.RewardRedeemed.Redemption.Reward.Title == AnecdotChannelPoints)
                {
                    GetAnecdote(e.RewardRedeemed.Redemption.UserInput, e.RewardRedeemed.Redemption.User.DisplayName);
                    return;
                }

                if (e.RewardRedeemed.Redemption.Reward.Title == AnecdotsFromFileChannelPoint)
                {
                    AnecdoteFromFiles();
                }
            }

            if (TypeOfMessageWilTts == "Highlighted (own name)" || TypeOfMessageWilTts == "Highlighted color and own name")
            {
                TTS(e.RewardRedeemed.Redemption.UserInput, e.RewardRedeemed.Redemption.User.DisplayName);
                return;
            }

            if (e.RewardRedeemed.Redemption.Reward.Title == MutedForTimeUserNameChannelPointReward)
            {
                if (MutedForTimeMinutes > 0)
                {
                    MutedUserName = e.RewardRedeemed.Redemption.UserInput.Replace(" ", "");
                    MutedUserName = MutedUserName.Replace("@", "");
                    mutedUsersForTimeList.Insert(0, new mutedUsersForTime { Str = MutedUserName.ToLower(), Time = DateTime.Now });
                }
            }

        }
        string resourceText;

        Random random = new Random();  

        private void TClientOnChatCommandReceived(object? sender, OnChatCommandReceivedArgs e)
        {
            if (!BlackList.Contains(e.Command.ChatMessage.Username))     
            {
                if (e.Command.ChatMessage.Message == $"!{AnecdotChatCommand}" && AnecdotChatCommand != "" && AnecdotChatCommand != " ")
                {
                    GetAnecdote(e.Command.ChatMessage.Message, e.Command.ChatMessage.Username);
                    return;
                }
                if (ViewerSkipAllQueueMessage != "" && e.Command.ChatMessage.Message == ViewerSkipAllQueueMessage)
                {
                    SynthText.SpeakAsyncCancelAll();
                    return;
                }
                if (ViewerSkipCurrentMessage != "" && e.Command.ChatMessage.Message == ViewerSkipCurrentMessage)
                {
                    SpeakCancell();
                    return;
                }
                if (ViewerSkipCurrentMessage != "" && e.Command.ChatMessage.Message == AnecdotChatCommand)
                {
                    GetAnecdote(e.Command.ChatMessage.Message, e.Command.ChatMessage.DisplayName);
                    return;
                }
                if(e.Command.ChatMessage.Message == AnecdotsFromFilesCommand)
                {
                    AnecdoteFromFiles();
                }
            }
        }
        private void AnecdoteFromFiles()
        {
            try
            {
                string[] blocks = resourceText.Split(new[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                int randomIndex = random.Next(0, blocks.Length);
                string randomBlock = blocks[randomIndex].Trim();
                if(sendAnecdotInChat)
                    TClient.SendMessage(TwitchNick, randomBlock);
                TTS(randomBlock, "");
            }
            catch { }

        }
        string responseBody;
        string finalAnecdot;
        private async void GetAnecdote(string text, string text2)
        { //Код ниже решает проблему с кодировкой, откуда берутся анекдоты 
            using (HttpClient httpClient = new HttpClient())
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                Encoding.GetEncoding("windows-1254");
                HttpResponseMessage response = await httpClient.GetAsync(anecdotUrl);
                response.EnsureSuccessStatusCode();
                responseBody = await response.Content.ReadAsStringAsync();
                finalAnecdot = responseBody.Substring(11, responseBody.Length - 11 - 2);
                finalAnecdot.Replace("негр", "н-слово");
                finalAnecdot.Replace("нигер", "н-слово");
                finalAnecdot.Replace("нига", "н-слово");
                finalAnecdot.Replace("гомик", "п-слово");
                if(sendAnecdotInChat)
                    TClient.SendMessage(TwitchNick, finalAnecdot);
                TTS(finalAnecdot, "");
            }
        }
        //TTS moment
        string Message;
        SpeechSynthesizer SynthText = new SpeechSynthesizer();
        private void TClientOnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            if (TypeOfMessageWilTts == "Everything")
            {
                TTS(e.ChatMessage.Message, e.ChatMessage.Username);
                return;
            }
            else if (TypeOfMessageWilTts == "Highlighted with color" || TypeOfMessageWilTts == "Highlighted color and own name")
            {
                if (e.ChatMessage.IsHighlighted)
                {
                    TTS(e.ChatMessage.Message, e.ChatMessage.Username);
                    return;
                }
            }
        }

        private void TClientOnConnected(object? sender, OnConnectedArgs e)
        {
            try
            {
                TClient.SendMessage(TwitchNick, "Connected");
            }
            catch
            {

            }

        }

        //TTS part
        string[] words;
        string wordReplacedMessage;
        string processedMessage; 
        string emojiPattern = @"(?:[\u203C-\u3299\u00A9\u00AE\u2000-\u3300\uF000-\uFFFF]|[\uD800-\uDBFF][\uDC00-\uDFFF])";
        void TTS(string chatMessage, string userName)
        {
            if (!BlackList.Contains(userName.ToLower()) && chatMessage[0] != ttsIgnore && !mutedUsersForTimeList.Any(test => test.Str == userName))
            {
                if (ViewerSkipAllQueueMessage != "" && chatMessage == ViewerSkipAllQueueMessage)
                {
                    SynthText.SpeakAsyncCancelAll();
                    return;
                }
                if (ViewerSkipCurrentMessage != "" && chatMessage == ViewerSkipCurrentMessage)
                {
                    SpeakCancell();
                    return;
                }

                //Replaces multiple dots in a row with single dot so next regex not replace two or more dot with word "link"
                Message = Regex.Replace(chatMessage, @"\.{2,}", ". ");
                //TTS will read long link as one word "link" instead of every letter
                Message = Regex.Replace(Message, @"(?:http(s)?:\/\/)?[\w.-]+\D(?:\.[\w\.-]+)+[\w\-\._~:/?%#[\]@!\$&'\(\)\*\+,;=.]+", "link");

                //for example russian TTS yuri will crash the programm because of emoji.
                //Replace emoji
                string emojiPattern = @"(?:[\u203C-\u3299\u00A9\u00AE\u2000-\u3300\uF000-\uFFFF]|[\uD800-\uDBFF][\uDC00-\uDFFF])";
                if (TtsClearEmoji)
                {
                    Message = Regex.Replace(Message, emojiPattern, string.Empty);
                    // this ^ gives me ChatGPT3.5 . this v i found in internet and upper works perfectly fine
                    //Message = Regex.Replace(Message, @"\p{Cs}", "");
                }
                //replace words in messages
                processedMessage = Message;
                if (WhatToReplace.Count > 0) //надо ли вообще менять
                {
                    processedMessage = "";
                    wordReplacedMessage = "";
                    words = Message.ToLower().Split(' ');
                    foreach (string word in words)
                    {
                        wordReplacedMessage = word;
                        try
                        {
                            wordReplacedMessage = WhatToSubstitude[WhatToReplace.IndexOf(word)];
                        }
                        catch
                        {

                        }
                        processedMessage = $"{processedMessage} {wordReplacedMessage}";

                    }
                }
                try
                {
                    SynthText.SpeakAsync(processedMessage);
                }
                catch { }
            }
        }


        //The methods below are needed to retrieve the information entered by users in the main window
        internal void ClearEmoji(bool @checked)
        {
            TtsClearEmoji = @checked;
        }

        internal void SetTtsVolume(int value)
        {
            SynthText.Volume = value;
        }

        internal void SetTtsSpeed(int value)
        {
            SynthText.Rate = value;
        }

        internal void SetTtsName(string text)
        {
            SynthText.SelectVoice(text);
        }

        internal void AddToBlackList(string v)
        {
            BlackList.Insert(BlackList.Count, v);
        }

        internal void AddToWhatToReplace(string v)
        {
            WhatToReplace.Insert(WhatToReplace.Count, v.ToLower());
        }

        internal void AddToSubstitude(string v)
        {
            WhatToSubstitude.Insert(WhatToSubstitude.Count, v);
        }

        internal void GetBlackListDeleteItem(int v)
        {
            if (BlackList.Count <= 1)
                BlackList.Clear();
            else
                BlackList.RemoveAt(v);
        }

        internal void GetDeleteReplaceAndSubstitudeItem(int selectedIndex)
        {
            if (WhatToReplace.Count <= 1)
            {
                WhatToReplace.Clear();
                WhatToSubstitude.Clear();
            }

            else
            { //Индекс не имеет значения т.к. они всегда равны
                WhatToReplace.RemoveAt(selectedIndex);
                WhatToSubstitude.RemoveAt(selectedIndex);
            }
        }

        internal void SpeakCancell()
        {
            //skip only the current spoken message
            var current = SynthText.GetCurrentlySpokenPrompt();

            if (current != null)
                SynthText.SpeakAsyncCancel(current);

        }
        string ViewerSkipCurrentMessage;
        internal void ViewerSkipCurrentTtsMessage(string text)
        {
            ViewerSkipCurrentMessage = text;
        }

        string ViewerSkipAllQueueMessage;
        internal void ViewerSkipAllTtsQueueMessage(string text)
        {
            ViewerSkipAllQueueMessage = text;
        }
        char ttsIgnore;
        internal void DoNotTtsIfStartWith(char text)
        {
            try { ttsIgnore = text; }
            catch { }
        }

        string HighlightedAward;
        internal void HighlightedAwardName(string text)
        {
            HighlightedAward = text;
        }

        string TypeOfMessageWilTts;
        internal void TypeOfMessageTts(string text)
        {
            TypeOfMessageWilTts = text;
        }

        internal void AddToReplaceAndSubstitude(string v1, string v2)
        {
            WhatToReplace.Insert(WhatToReplace.Count, v1);
            WhatToSubstitude.Insert(WhatToSubstitude.Count, v2);
        }

        internal void AnecdotChatCommandChanged(string text)
        {
            AnecdotChatCommand = text;
        }

        internal void AnecdotChatChannelPoints(string text)
        {
            AnecdotChannelPoints = text;
        }
        string AnecdotsFromFilesCommand;
        internal void AnecdotsFromFilesChatCommand(string text)
        {
            AnecdotsFromFilesCommand = text;
        }
        string AnecdotsFromFileChannelPoint;
        internal void AnecdotsFromFilesChannelPointsCommand(string text)
        {
            AnecdotsFromFileChannelPoint = text;
        }

        string emptyString = Environment.NewLine;

        //removes all the emojis from the files because they crashing TTS, so its easier to delete them
        internal void RebuildAnecdotes(string item)
        {
            try
            {
                resourceText = $"{resourceText}{emptyString}{emptyString}{File.ReadAllText($"DataForProgram\\Anecdots\\{item}")}";
                resourceText = Regex.Replace(resourceText, emojiPattern, string.Empty);
            }
            catch { }
        }

        internal void ClearAnecdotes()
        {
            resourceText = "";
        }
        string MutedForTimeUserNameChannelPointReward;
        string MutedForTimeUserName;
        internal void MutedForTimeChannelPoints(string text)
        {
            MutedForTimeUserNameChannelPointReward = text;
        }

        internal void Disconnect()
        {
            TClient.Disconnect();
        }

        internal void Reconnect()
        {
            TClient.Reconnect();
        }
        static int MutedForTimeMinutes;
        internal void MutedForTime(string text)
        {
            try
            {
                MutedForTimeMinutes = Convert.ToInt16(text); // в обнимку с чатом гпт творю чудеса)
            }
            catch { }
            
        }
        bool sendAnecdotInChat;
        internal void AnecdotsDoNotSendInChat(bool v)
        {
            sendAnecdotInChat = v;  
        }
    }
}