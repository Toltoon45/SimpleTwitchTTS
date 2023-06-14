using System.Speech.Synthesis;
using TwitchLib.Client;
using TwitchLib.Communication.Events;
using System.Text.Json;
using Newtonsoft.Json;

namespace SimpleTwitchTTS
{
    public partial class MainWindow : Form
    {
        SpeechSynthesizer Synth = new SpeechSynthesizer();
        public MainWindow()
        {
            InitializeComponent();
            //load all
            string profilesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "profiles");
            string[] jsonFiles = Directory.GetFiles(profilesDirectory, "*.json");

            foreach (string filePath in jsonFiles)
            {
                string fileName = Path.GetFileName(filePath);
                comboBoxProfileSelect.Items.Add(fileName);
            }

            //load last used settings
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

            foreach (InstalledVoice voice in Synth.GetInstalledVoices())
            {
                comboBoxInstalledVoices.Items.Add(voice.VoiceInfo.Name);
            }

            if (!File.Exists("BlackList.txt"))
                using (System.IO.FileStream fs = System.IO.File.Create("BlackList.txt")) ;
            using (System.IO.StreamReader sr = new System.IO.StreamReader("BlackList.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBoxBlackList.Items.Add(sr.ReadLine());
                }
            }
        }

        private void linkLabelTwitchApi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("explorer.exe", "https://twitchtokengenerator.com/");
            }
            catch
            {
                linkLabelTwitchApi.Text = "https://twitchtokengenerator.com/";
                Clipboard.SetText(linkLabelTwitchApi.Text);
                toolTipInfoForConnection.SetToolTip(linkLabelTwitchApi, "Copied, go to browser!");
            }

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
            Properties.Settings.Default.Save();


            using (System.IO.StreamWriter sw = new System.IO.StreamWriter("BlackList.txt"))
            {
                for (int i = 0; i < listBoxBlackList.Items.Count; i++)
                    sw.WriteLine(listBoxBlackList.Items[i].ToString());
            }
        }

        TwitchClient TClient = new TwitchClient();
        TwitchBot TWbot = new TwitchBot();
        bool Connect = false;



        private void buttonTwitchConnect_Click(object sender, EventArgs e)
        {
            if (Connect == false)
            {
                labelConnectionStatus.ForeColor = Color.Black;
                labelConnectionStatus.Text = "Conntecing...";
                try
                {
                    TClient = TWbot.Connect(textBoxTwitchApi.Text, textBoxTwitchNick.Text, comboBoxInstalledVoices.Text, TClient);
                    if (TClient != null)
                    {
                        TClient.OnDisconnected += TClientOnDisconnected;
                        Connect = true;

                        foreach (var item in listBoxBlackList.Items)
                        {
                            TWbot.AddToBlackList(Convert.ToString(item));
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
                this.Invoke(new Action(() => labelConnectionStatus.Text = "Disconnected"));
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
                Synth.Speak("test 1 2 3 test");
            }

        }

        private void trackBarTtsVolume_Scroll(object sender, EventArgs e)
        {

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
            int index = listBoxBlackList.SelectedIndex * -1;
            TWbot.GetBlackListDeleteItem(listBoxBlackList.SelectedIndex);
            listBoxBlackList.Items.RemoveAt(listBoxBlackList.SelectedIndex);
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
        private void buttonProfileAdd_Click(object sender, EventArgs e)
        {
            var data = new
            {
                textBoxTestTts = textBoxTestTts.Text,
                textBoxTwitchApi = textBoxTwitchApi.Text,
                textBoxTwitchNick = textBoxTwitchNick.Text,
                comboBoxInstalledVoices = comboBoxInstalledVoices.Text,
                checkBoxClearEmoji = checkBoxClearEmoji.Checked,
                trackBarTtsVolume = trackBarTtsVolume.Value,
                trackBarTtsSpeed = trackBarTtsSpeed.Value,
                textBoxViewerSkipCurrentTtsMessage = textBoxViewerSkipCurrentTtsMessage.Text,
                textBoxViewerSkipAllQueueMessage = textBoxViewerSkipAllQueueMessage.Text,
                textBoxDoNotTtsIfStartWith = textBoxDoNotTtsIfStartWith.Text
            };
            var jsonData = System.Text.Json.JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText($@"profiles//{textBoxProfileAdd.Text}.json", jsonData);
        }

        private void buttonProfileDelete_Click(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void buttonProfileLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists($@"profiles//{comboBoxProfileSelect.Text}"))
            {
                dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText($@"profiles//{comboBoxProfileSelect.Text}"));

                textBoxTestTts.Text = jsonFile.SelectToken("textBoxTestTts");
                textBoxTwitchApi.Text = jsonFile.SelectToken("textBoxTwitchApi");
                textBoxTwitchNick.Text = jsonFile.SelectToken("textBoxTwitchNick");
                comboBoxInstalledVoices.Text = jsonFile.SelectToken("comboBoxInstalledVoices");
                checkBoxClearEmoji.Checked = jsonFile.SelectToken("checkBoxClearEmoji");
                trackBarTtsVolume.Value = jsonFile.SelectToken("trackBarTtsVolume");
                trackBarTtsSpeed.Value = jsonFile.SelectToken("trackBarTtsSpeed");
                textBoxViewerSkipCurrentTtsMessage.Text = jsonFile.SelectToken("textBoxViewerSkipCurrentTtsMessage");
                textBoxViewerSkipAllQueueMessage.Text = jsonFile.SelectToken("textBoxViewerSkipAllQueueMessage");
                textBoxDoNotTtsIfStartWith.Text = jsonFile.SelectToken("textBoxDoNotTtsIfStartWith");
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    File.Delete($@"profiles//{comboBoxProfileSelect.Text}");
                    comboBoxProfileSelect.Items.Remove(comboBoxProfileSelect);
                }
                catch
                {

                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}