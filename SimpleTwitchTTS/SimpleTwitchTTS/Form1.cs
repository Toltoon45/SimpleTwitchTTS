using System.Speech.Synthesis;
using TwitchLib.Client;
using TwitchLib.Communication.Events;

namespace SimpleTwitchTTS
{
    public partial class MainWindow : Form
    {
        SpeechSynthesizer Synth = new SpeechSynthesizer();
        public MainWindow()
        {
            InitializeComponent();

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
            labelConnectionStatus.ForeColor = Color.Black;
            labelConnectionStatus.Text = "Conntecing...";
            if (Connect == false)
            {
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
                Connect = false;
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

        private void trackBarTtsVolume_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarTtsVolume_ValueChanged(object sender, EventArgs e)
        {
            labelTtsVolume.Text = Convert.ToString(trackBarTtsVolume.Value);
            TWbot.SetTtsVolume(trackBarTtsVolume.Value);
        }

        private void trackBarTtsSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelTtsSpeed.Text = Convert.ToString(trackBarTtsSpeed.Value);
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
    }
}