using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Models;
using System.Text.RegularExpressions;
using System.Speech.Synthesis;

namespace SimpleTwitchTTS
{
    internal class TwitchBot
    {

        string TwitchNick;
        ConnectionCredentials Creds;
        TwitchClient TClient;
        bool TtsClearEmoji = false;

        int TtsVolume;
        int TtsSpeed;

        List<string> BlackList = new List<string>();

        //TClient needed to change connection status.
        internal TwitchClient? Connect(string Api, string Nick, string VoiceName, TwitchClient client)
        {
            try
            {
                if (client != null)
                {
                    TClient = client;
                    Creds = new ConnectionCredentials(Nick, Api);
                    TwitchNick = Nick;
                    SynthText.SelectVoice(VoiceName);

                    TClient.OnConnected += TClientOnConnected;
                    TClient.OnMessageReceived += TClientOnMessageReceived;

                    TClient.Initialize(Creds, Nick);
                    TClient.Connect();

                    return TClient;
                }
                else { return null; }

            }
            catch
            {
                if (TClient != null)
                {
                    TClient.OnConnected -= TClientOnConnected;
                    TClient.OnMessageReceived -= TClientOnMessageReceived;
                }

                return null;

            }


        }
        //Part With TTS
        string Message;
        SpeechSynthesizer SynthText = new SpeechSynthesizer();
        private void TClientOnMessageReceived(object? sender, OnMessageReceivedArgs e)
        {
            if (!BlackList.Contains(e.ChatMessage.Username) && e.ChatMessage.Message[0] != ttsIgnore)
            {
                if (ViewerSkipAllQueueMessage != "" && e.ChatMessage.Message == ViewerSkipAllQueueMessage)
                {
                    SynthText.SpeakAsyncCancelAll();
                    return;
                }

                
                if (ViewerSkipCurrentMessage != "" && e.ChatMessage.Message == ViewerSkipCurrentMessage)
                {
                    SpeakCancell();
                    return;
                }

                Message = Message.Replace("..", "");

                Message = Regex.Replace(Message, @"(?:http(s)?:\/\/)?[\w.-]+\D(?:\.[\w\.-]+)+[\w\-\._~:/?%#[\]@!\$&'\(\)\*\+,;=.]+", "link");


                //Russian TTS yuri crash the programm because of emoji.
                //Replace emoji
                if (TtsClearEmoji)
                {
                    Message = Regex.Replace(Message, @"\p{Cs}", "");
                }
                SynthText.SpeakAsync(Message);
            }
        }

        private void TClientOnConnected(object? sender, OnConnectedArgs e)
        {
            try
            {
                TClient.SendMessage(TwitchNick, "gotovo");
            }
            catch
            {

            }

        }



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

        internal void GetBlackListDeleteItem(int v)
        {
            if (BlackList.Count <= 1)
                BlackList.Clear();
            else
                BlackList.RemoveAt(v);
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
    }
}