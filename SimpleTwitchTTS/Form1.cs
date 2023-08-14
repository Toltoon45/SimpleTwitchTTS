using System.Speech.Synthesis;
using TwitchLib.Client;
using TwitchLib.Communication.Events;
using System.Text.Json;
using Newtonsoft.Json;
using System.Globalization;
using System.Diagnostics;
using System.Net.Http.Headers;


namespace SimpleTwitchTTS
{
    public partial class MainWindow : Form
    {
        SpeechSynthesizer Synth = new SpeechSynthesizer();

        public MainWindow()
        {
            InitializeComponent();
            LoadComponents();
        }

        private void LoadComponents()
        {
            //load all
            try
            {
                if (!Directory.Exists("DataForProgram/BlackList"))
                    Directory.CreateDirectory("DataForProgram/BlackList");
                if (!Directory.Exists("DataForProgram/Profiles"))
                    Directory.CreateDirectory("DataForProgram/Profiles");
                if (!Directory.Exists("DataForProgram/wordReplace"))
                    Directory.CreateDirectory("DataForProgram/wordReplace");
                textBoxTwitchApi.Text = Properties.Settings.Default.TextBoxTwitchApi;
                textBoxTwitchNick.Text = Properties.Settings.Default.TextBoxTwitchNick;
                checkBoxClearEmoji.Checked = Properties.Settings.Default.CheckBoxClearEmoji;
                comboBoxInstalledVoices.Text = Properties.Settings.Default.ComboBoxInstalledVoiceSelect;
                toolTipInfoForConnection.SetToolTip(comboBoxInstalledVoices, comboBoxInstalledVoices.Text);
                trackBarTtsVolume.Value = Properties.Settings.Default.TtsVolume;
                trackBarTtsSpeed.Value = Properties.Settings.Default.TtsSpeed;
                textBoxViewerSkipAllQueueMessage.Text = Properties.Settings.Default.TtsSkipAll;
                textBoxViewerSkipCurrentTtsMessage.Text = Properties.Settings.Default.TtsSkipCurrent;
                textBoxDoNotTtsIfStartWith.Text = Properties.Settings.Default.TtsIgnore;
                comboBoxProfileSelect.Text = Properties.Settings.Default.ProfileName;
                textBoxTwitchClientID.Text = Properties.Settings.Default.TwitchToken;
                textBoxHighlightedMessageName.Text = Properties.Settings.Default.HighlightedMessageName;
                comboBoxTypeOfMessageTts.Text = Properties.Settings.Default.TtsMessageType;
                textBoxAnecdotChatCommand.Text = Properties.Settings.Default.AnecdotChatCommand;
                textBoxAnecdotChannelPoints.Text = Properties.Settings.Default.AnecdotChannelPoints;
                labelConnectionStatus.Text = "";


                string profilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"DataForProgram\\Profiles");
                string[] jsonFiles = Directory.GetFiles(profilesDirectory, "*.json");

                foreach (string filePath in jsonFiles)
                {
                    string fileName = Path.GetFileName(filePath);
                    comboBoxProfileSelect.Items.Add(fileName);
                }



                foreach (InstalledVoice voice in Synth.GetInstalledVoices())
                {
                    comboBoxInstalledVoices.Items.Add(voice.VoiceInfo.Name);
                }

                createAndLoadFile("BlackList", "DataForProgram/BlackList", listBoxBlackList);
                createAndLoadFile("WhatToReplace", "DataForProgram/wordReplace", listBoxTtsWhatToReplace);
                createAndLoadFile("Substitute", "DataForProgram/wordReplace", listBoxTtsSubstitute);


            }
            catch (Exception)
            {

                throw;
            }
        }

        //create txt file if it not exist, or program wont even start
        private void createAndLoadFile(string FileName, string path, ListBox listBox)
        { //создание файла и запись текста в два разных файла, загрузка обратно в лисстбокс и передача в бот.цс
            if (!File.Exists($"{path}\\{FileName}.txt"))
                using (System.IO.FileStream fs = System.IO.File.Create($@"{path}\\{FileName}.txt")) ;
            using (System.IO.StreamReader sr = new System.IO.StreamReader($@"{path}\\{FileName}.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox.Items.Add(sr.ReadLine());
                }
            }
        }

        private void linkLabelTwitchApi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Application.OpenForms.OfType<FormApiGuide>().Any())
            {
                FormApiGuide FormExperimentalSettings = new FormApiGuide();
                FormExperimentalSettings.Show();
            }
            //try
            //{
            //    System.Diagnostics.Process.Start("explorer.exe", "https://twitchtokengenerator.com/");
            //}
            //catch
            //{
            //    linkLabelTwitchApi.Text = "https://twitchtokengenerator.com/";
            //    Clipboard.SetText(linkLabelTwitchApi.Text);
            //    toolTipInfoForConnection.SetToolTip(linkLabelTwitchApi, "Copied, go to browser!");
            //}

        }


        private void textBoxTwitchApi_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.TextBoxTwitchApi = textBoxTwitchApi.Text;
            Properties.Settings.Default.TextBoxTwitchNick = textBoxTwitchNick.Text;
            Properties.Settings.Default.CheckBoxClearEmoji = checkBoxClearEmoji.Checked;
            Properties.Settings.Default.ComboBoxInstalledVoiceSelect = comboBoxInstalledVoices.Text;
            Properties.Settings.Default.TtsVolume = trackBarTtsVolume.Value;
            Properties.Settings.Default.TtsSpeed = trackBarTtsSpeed.Value;
            Properties.Settings.Default.TtsSkipAll = textBoxViewerSkipAllQueueMessage.Text;
            Properties.Settings.Default.TtsSkipCurrent = textBoxViewerSkipCurrentTtsMessage.Text;
            Properties.Settings.Default.TtsIgnore = textBoxDoNotTtsIfStartWith.Text;
            Properties.Settings.Default.ProfileName = comboBoxProfileSelect.Text;
            Properties.Settings.Default.TwitchToken = textBoxTwitchClientID.Text;
            Properties.Settings.Default.HighlightedMessageName = textBoxHighlightedMessageName.Text;
            Properties.Settings.Default.TtsMessageType = comboBoxTypeOfMessageTts.Text;
            Properties.Settings.Default.AnecdotChatCommand = textBoxAnecdotChatCommand.Text;
            Properties.Settings.Default.AnecdotChannelPoints = textBoxAnecdotChannelPoints.Text;
            Properties.Settings.Default.Save();

            saveFile("BlackList", "DataForProgram/BlackList", listBoxBlackList);
            saveFile("WhatToReplace", "DataForProgram/wordReplace", listBoxTtsWhatToReplace);
            saveFile("Substitute", "DataForProgram/wordReplace", listBoxTtsSubstitute);
        }

        private void saveFile(string fileName, string path, ListBox listBox)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter($"{path}\\{fileName}.txt"))
            {
                for (int i = 0; i < listBox.Items.Count; i++)
                    sw.WriteLine(listBox.Items[i].ToString());
            }
        }

        TwitchClient TClient = new TwitchClient();
        TwitchBot TWbot = new TwitchBot();
        bool Connect = false;


        string TwitchTokenFromHttpRequest;
        private async void buttonTwitchConnect_Click(object sender, EventArgs e)
        {
            await GetTwitchUserId();
            if (Connect == false)
            {
                labelConnectionStatus.ForeColor = Color.Black;
                labelConnectionStatus.Text = "Conntecing...";
                try
                {
                    TClient = TWbot.Connect(textBoxTwitchApi.Text, textBoxTwitchNick.Text, TwitchTokenFromHttpRequest, comboBoxInstalledVoices.Text, TClient, textBoxAnecdotChatCommand.Text, textBoxAnecdotChannelPoints.Text);
                    if (TClient != null)
                    {
                        TClient.OnDisconnected += TClientOnDisconnected;
                        Connect = true;

                        foreach (var item in listBoxBlackList.Items)
                        {
                            TWbot.AddToBlackList(Convert.ToString(item));
                        }
                        foreach (var item in listBoxTtsWhatToReplace.Items)
                        {
                            TWbot.AddToWhatToReplace(Convert.ToString(item));
                        }
                        foreach (var item in listBoxTtsSubstitute.Items)
                        {
                            TWbot.AddToSubstitude(Convert.ToString(item));
                        }
                    }
                }
                catch
                {
                    labelConnectionStatus.Text = "Did not connected";
                    labelConnectionStatus.ForeColor = Color.Purple;
                    Connect = false;
                }

                labelConnectionStatus.Text = (TClient != null) ? "Connected" : "Did not connect";
                labelConnectionStatus.ForeColor = (TClient != null) ? Color.Green : Color.Purple;
                Connect = (TClient != null) ? true : false;
                //Connect = false;
            }

        }
        //change status of connection.
        private void TClientOnDisconnected(object? sender, OnDisconnectedEventArgs e)
        {

            if (InvokeRequired)
            {
                this.Invoke(new Action(() => labelConnectionStatus.Text = "Disconnected, restart program"));
                this.Invoke(new Action(() => labelConnectionStatus.ForeColor = Color.Red));
            }
            Connect = false;

        }

        internal void TWbotDisconnected()
        {
            labelConnectionStatus.Text = "Disconnected";
            labelConnectionStatus.ForeColor = Color.Red;
        }

        private void checkBoxClearEmoji_CheckedChanged(object sender, EventArgs e)
        {
            TWbot.ClearEmoji(checkBoxClearEmoji.Checked);
        }

        private void comboBoxInstalledVoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTipInfoForConnection.SetToolTip(comboBoxInstalledVoices, comboBoxInstalledVoices.Text);

            TWbot.SetTtsName(comboBoxInstalledVoices.Text);
        }

        private void buttonTestTts_Click(object sender, EventArgs e)
        {
            try
            {
                Synth.SelectVoice(comboBoxInstalledVoices.Text);


                Synth.SpeakAsync(textBoxTestTts.Text);
            }
            catch
            {
                Synth.SpeakAsync(textBoxTestTts.Text);
            }
        }

        private void buttonTestTtsSkip_Click(object sender, EventArgs e)
        {
            Synth.SpeakAsyncCancelAll();
        }

        private void trackBarTtsVolume_ValueChanged(object sender, EventArgs e)
        {
            labelTtsVolume.Text = Convert.ToString(trackBarTtsVolume.Value);
            Synth.Volume = (trackBarTtsVolume.Value);
            TWbot.SetTtsVolume(trackBarTtsVolume.Value);
        }

        private void trackBarTtsSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelTtsSpeed.Text = Convert.ToString(trackBarTtsSpeed.Value);
            Synth.Rate = trackBarTtsSpeed.Value;
            TWbot.SetTtsSpeed(trackBarTtsSpeed.Value);
        }

        private void buttonAddToBlackList_Click(object sender, EventArgs e)
        {
            if (!listBoxBlackList.Items.Contains(textBoxBlackList.Text))
            {
                listBoxBlackList.Items.Add(textBoxBlackList.Text);

                TWbot.AddToBlackList(textBoxBlackList.Text.ToLower());
            }
        }

        private void buttonRemoveFromBlackList_Click(object sender, EventArgs e)
        {
            try
            {
                TWbot.GetBlackListDeleteItem(listBoxBlackList.SelectedIndex);
                listBoxBlackList.Items.RemoveAt(listBoxBlackList.SelectedIndex);
            }
            catch { };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearEntireQueue_Click(object sender, EventArgs e)
        {
            TWbot.SpeakCancell();
        }

        private void buttonSkipCurrentMessage_Click(object sender, EventArgs e)
        {
            //TWbot.SpeakCancel();
        }

        private void textBoxViewerSkipCurrentTtsMessage_TextChanged(object sender, EventArgs e)
        {
            TWbot.ViewerSkipCurrentTtsMessage(textBoxViewerSkipCurrentTtsMessage.Text);
        }


        private void textBoxViewerSkipAllQueueMessage_TextChanged(object sender, EventArgs e)
        {
            TWbot.ViewerSkipAllTtsQueueMessage(textBoxViewerSkipAllQueueMessage.Text);
        }

        private void textBoxHighlightedMessageName_TextChanged(object sender, EventArgs e)
        {
            TWbot.HighlightedAwardName(textBoxHighlightedMessageName.Text);
        }

        private void textBoxDoNotTtsIfStartWith_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TWbot.DoNotTtsIfStartWith(Convert.ToChar(textBoxDoNotTtsIfStartWith.Text));
            }
            catch
            {
            }

        }

        //save and load from json
        private void buttonProfileAddClick(object sender, EventArgs e)
        {
            var data = new
            {
                textBoxTwitchApi = textBoxTwitchApi.Text,
                textBoxTwitchClientId = textBoxTwitchClientID.Text,
                textBoxTwitchNick = textBoxTwitchNick.Text,
                comboBoxInstalledVoices = comboBoxInstalledVoices.Text,
                checkBoxClearEmoji = checkBoxClearEmoji.Checked,
                trackBarTtsVolume = trackBarTtsVolume.Value,
                trackBarTtsSpeed = trackBarTtsSpeed.Value,
                textBoxViewerSkipCurrentTtsMessage = textBoxViewerSkipCurrentTtsMessage.Text,
                textBoxViewerSkipAllQueueMessage = textBoxViewerSkipAllQueueMessage.Text,
                textBoxDoNotTtsIfStartWith = textBoxDoNotTtsIfStartWith.Text,
                textBoxTestTts = textBoxTestTts.Text,
                textBoxHighlightedMessageName = textBoxHighlightedMessageName.Text,
                comboBoxTypeOfMessageTts = comboBoxTypeOfMessageTts.Text
            };
            try
            {
                var jsonData = System.Text.Json.JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText($@"DataForProgram//Profiles//{textBoxProfileAdd.Text}.json", jsonData);
                if (!comboBoxProfileSelect.Items.Contains($"{textBoxProfileAdd.Text}.json"))
                    comboBoxProfileSelect.Items.Add($"{textBoxProfileAdd.Text}.json");

            }
            catch (Exception)
            {
            }

        }

        private void buttonProfileLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"DataForProgram/Profiles//{comboBoxProfileSelect.Text}"))
            {
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText($@"DataForProgram/Profiles//{comboBoxProfileSelect.Text}"));

                textBoxTwitchApi.Text = jsonFile.SelectToken("textBoxTwitchApi");
                textBoxTwitchClientID.Text = jsonFile.SelectToken("textBoxTwitchClientId");
                textBoxTwitchNick.Text = jsonFile.SelectToken("textBoxTwitchNick");
                comboBoxInstalledVoices.Text = jsonFile.SelectToken("comboBoxInstalledVoices");
                checkBoxClearEmoji.Checked = jsonFile.SelectToken("checkBoxClearEmoji");
                trackBarTtsVolume.Value = jsonFile.SelectToken("trackBarTtsVolume");
                trackBarTtsSpeed.Value = jsonFile.SelectToken("trackBarTtsSpeed");
                textBoxViewerSkipCurrentTtsMessage.Text = jsonFile.SelectToken("textBoxViewerSkipCurrentTtsMessage");
                textBoxViewerSkipAllQueueMessage.Text = jsonFile.SelectToken("textBoxViewerSkipAllQueueMessage");
                textBoxDoNotTtsIfStartWith.Text = jsonFile.SelectToken("textBoxDoNotTtsIfStartWith");
                textBoxTestTts.Text = jsonFile.SelectToken("textBoxTestTts");
                textBoxHighlightedMessageName.Text = jsonFile.SelectToken("textBoxHighlightedMessageName");
                comboBoxTypeOfMessageTts.Text = jsonFile.SelectToken("textBoxHighlightedMessageName");
            }
        }

        CultureInfo LanguageRUS = new CultureInfo("ru-RU");
        CultureInfo LanguageENG = new CultureInfo("en-US");
        private void buttonLanguageChange_Click(object sender, EventArgs e)
        {
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            if (Convert.ToString(currentCulture) == "ru-RU")
            {
                Thread.CurrentThread.CurrentCulture = LanguageENG;
                Thread.CurrentThread.CurrentUICulture = LanguageENG;
            }
            else
            {
                Thread.CurrentThread.CurrentCulture = LanguageRUS;
                Thread.CurrentThread.CurrentUICulture = LanguageRUS;
            }
            Controls.Clear();
            InitializeComponent();
            LoadComponents();

        }

        private void buttonProfileDelete(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete($@"DataForProgram/Profiles//{comboBoxProfileSelect.Text}");
                    comboBoxProfileSelect.Items.Remove(comboBoxProfileSelect.SelectedItem);
                }
                catch
                {
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void buttonProfileOpenFolder(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "DataForProgram");
        }

        private void linkLabelTwitchToken_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://www.streamweasels.com/tools/convert-twitch-username-to-user-id/");
        }

        private void buttonOpenExperimentalSettings_Click(object sender, EventArgs e)
        {
            if (!Application.OpenForms.OfType<FormApiGuide>().Any())
            {
                FormApiGuide FormExperimentalSettings = new FormApiGuide();
                FormExperimentalSettings.Show();
            }

        }

        private void comboBoxTypeOfMessageTts_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTipInfoForConnection.SetToolTip(comboBoxTypeOfMessageTts, comboBoxTypeOfMessageTts.Text);
            TWbot.TypeOfMessageTts(comboBoxTypeOfMessageTts.Text);
        }

        private void textBoxTwitchToken_TextChanged(object sender, EventArgs e)
        {
            //delete
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonTtsTextReplace_Click(object sender, EventArgs e)
        {
            if (textBoxTtsWhatToReplace.Text != "" && textBoxTtsSubstitute.Text != "" && !listBoxTtsWhatToReplace.Items.Contains(textBoxTtsWhatToReplace.Text))
            {
                listBoxTtsWhatToReplace.Items.Add(textBoxTtsWhatToReplace.Text);
                listBoxTtsSubstitute.Items.Add(textBoxTtsSubstitute.Text);
            }
            TWbot.AddToReplaceAndSubstitude(textBoxTtsWhatToReplace.Text, textBoxTtsSubstitute.Text);
        }

        int selectedIndex;
        private void buttonDeleteReplaceAndSubstitude_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxTtsWhatToReplace.Items.Count == 0)
                    selectedIndex = listBoxTtsSubstitute.SelectedIndex;
                else
                    selectedIndex = listBoxTtsWhatToReplace.SelectedIndex;

                TWbot.GetDeleteReplaceAndSubstitudeItem(listBoxTtsWhatToReplace.SelectedIndex, listBoxTtsSubstitute.SelectedIndex);
                try
                { //try is needed because if V is empty then program moved to catch and next remove not working
                    listBoxTtsWhatToReplace.Items.RemoveAt(selectedIndex);
                }
                catch { }

                listBoxTtsSubstitute.Items.RemoveAt(selectedIndex);
            }
            catch { }
        }

        private void listBoxTtsWhatToReplace_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxTtsSubstitute.SelectedIndex = listBoxTtsWhatToReplace.SelectedIndex;
            }
            catch { }
            if (listBoxTtsSubstitute.SelectedIndex != listBoxTtsWhatToReplace.SelectedIndex)
            {
                listBoxTtsWhatToReplace.SelectedIndex = -1;
                listBoxTtsSubstitute.SelectedIndex = -1;
            }
        }

        private void listBoxTtsSubstitute_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                listBoxTtsWhatToReplace.SelectedIndex = listBoxTtsSubstitute.SelectedIndex;
            }
            catch { }
            if (listBoxTtsSubstitute.SelectedIndex != listBoxTtsWhatToReplace.SelectedIndex)
            {
                listBoxTtsWhatToReplace.SelectedIndex = -1;
                listBoxTtsSubstitute.SelectedIndex = -1;
            }

        }


        //тест
        public delegate void UpdateLabelDelegate(string text);
        public event UpdateLabelDelegate UpdateLabelEvent;

        //method
        public void UpdateLabel(string text)
        {
            labelConnectionStatus.Invoke((MethodInvoker)(() => labelConnectionStatus.Text = text));

        }

        private void textBoxAnecdotChatCommand_TextChanged(object sender, EventArgs e)
        {
            TWbot.AnecdotChatCommandChanged(textBoxAnecdotChatCommand.Text);
        }

        private void textBoxAnecdotChannelPoints_TextChanged(object sender, EventArgs e)
        {
            TWbot.AnecdotChatChannelPoints(textBoxAnecdotChannelPoints.Text);
        }
        //отправить запрос в твич 
        private async Task<string> GetTwitchUserId()
        {
            using (HttpClient twitchToken = new HttpClient())
            {
                twitchToken.DefaultRequestHeaders.Add("Client-ID", textBoxTwitchClientID.Text);
                twitchToken.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", textBoxTwitchApi.Text);
                string url = $"https://api.twitch.tv/helix/users?login={textBoxTwitchNick.Text}";
                HttpResponseMessage response = await twitchToken.GetAsync(url);
                string responseBody = await response.Content.ReadAsStringAsync();
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                string userId = data.data[0].id;
                TwitchTokenFromHttpRequest = userId;
                return "";
            }
            return "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            GetTwitchUserId();
        }

        private void checkBoxOverAllWindows_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOverAllWindows.Checked)
            {
                TopMost = true;
            }
            else TopMost = false;
        }
    }
}