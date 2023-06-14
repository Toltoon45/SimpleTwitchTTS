namespace SimpleTwitchTTS
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            buttonTwitchConnect = new Button();
            textBoxTwitchApi = new TextBox();
            textBoxTwitchNick = new TextBox();
            linkLabelTwitchApi = new LinkLabel();
            toolTipInfoForConnection = new ToolTip(components);
            labelNickOfChannelToConnect = new Label();
            textBoxDoNotTtsIfStartWith = new TextBox();
            textBoxViewerSkipCurrentTtsMessage = new TextBox();
            textBoxViewerSkipAllQueueMessage = new TextBox();
            textBoxTestTts = new TextBox();
            textBoxProfileAdd = new TextBox();
            comboBoxProfileSelect = new ComboBox();
            labelConnectionStatus = new Label();
            checkBoxClearEmoji = new CheckBox();
            comboBoxInstalledVoices = new ComboBox();
            trackBarTtsVolume = new TrackBar();
            trackBarTtsSpeed = new TrackBar();
            labelTtsVolume = new Label();
            labelTtsSpeed = new Label();
            labelBlackList = new Label();
            textBoxBlackList = new TextBox();
            listBoxBlackList = new ListBox();
            buttonAddToBlackList = new Button();
            buttonRemoveFromBlackList = new Button();
            labelTtsVolumeName = new Label();
            labelTtsSpeedName = new Label();
            labelSkipMessage = new Label();
            buttonSkipCurrentMessage = new Button();
            buttonClearEntireQueue = new Button();
            labelAllowViewerToSkip = new Label();
            labelViewerSkipCurrent = new Label();
            labelViewerSkipCurrentMessage = new Label();
            labelViewerSkipAllQueue = new Label();
            labelDoNotTtsIfStartWith = new Label();
            labelTtsTest = new Label();
            buttonTestTts = new Button();
            buttonProfileAdd = new Button();
            buttonProfileLoad = new Button();
            button = new Button();
            labelProfileAdd = new Label();
            labelProfileDelete = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBarTtsVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTtsSpeed).BeginInit();
            SuspendLayout();
            // 
            // buttonTwitchConnect
            // 
            buttonTwitchConnect.Location = new Point(12, 12);
            buttonTwitchConnect.Name = "buttonTwitchConnect";
            buttonTwitchConnect.Size = new Size(60, 23);
            buttonTwitchConnect.TabIndex = 0;
            buttonTwitchConnect.Text = "Connect";
            buttonTwitchConnect.UseVisualStyleBackColor = true;
            buttonTwitchConnect.Click += buttonTwitchConnect_Click;
            // 
            // textBoxTwitchApi
            // 
            textBoxTwitchApi.Location = new Point(78, 12);
            textBoxTwitchApi.Name = "textBoxTwitchApi";
            textBoxTwitchApi.PasswordChar = '*';
            textBoxTwitchApi.Size = new Size(100, 23);
            textBoxTwitchApi.TabIndex = 1;
            toolTipInfoForConnection.SetToolTip(textBoxTwitchApi, "NEVER SHOW THIS ANYONE");
            textBoxTwitchApi.TextChanged += textBoxTwitchApi_TextChanged;
            // 
            // textBoxTwitchNick
            // 
            textBoxTwitchNick.Location = new Point(78, 41);
            textBoxTwitchNick.Name = "textBoxTwitchNick";
            textBoxTwitchNick.Size = new Size(100, 23);
            textBoxTwitchNick.TabIndex = 2;
            toolTipInfoForConnection.SetToolTip(textBoxTwitchNick, "nickname of the channel to connect to");
            // 
            // linkLabelTwitchApi
            // 
            linkLabelTwitchApi.AutoSize = true;
            linkLabelTwitchApi.Location = new Point(184, 16);
            linkLabelTwitchApi.Name = "linkLabelTwitchApi";
            linkLabelTwitchApi.Size = new Size(62, 15);
            linkLabelTwitchApi.TabIndex = 3;
            linkLabelTwitchApi.TabStop = true;
            linkLabelTwitchApi.Text = "Twitch Api";
            toolTipInfoForConnection.SetToolTip(linkLabelTwitchApi, "Please give all permissions");
            linkLabelTwitchApi.LinkClicked += linkLabelTwitchApi_LinkClicked;
            // 
            // toolTipInfoForConnection
            // 
            toolTipInfoForConnection.AutomaticDelay = 0;
            toolTipInfoForConnection.AutoPopDelay = 0;
            toolTipInfoForConnection.InitialDelay = 1;
            toolTipInfoForConnection.ReshowDelay = 100;
            // 
            // labelNickOfChannelToConnect
            // 
            labelNickOfChannelToConnect.AutoSize = true;
            labelNickOfChannelToConnect.Location = new Point(184, 41);
            labelNickOfChannelToConnect.Name = "labelNickOfChannelToConnect";
            labelNickOfChannelToConnect.Size = new Size(61, 15);
            labelNickOfChannelToConnect.TabIndex = 21;
            labelNickOfChannelToConnect.Text = "Nickname";
            toolTipInfoForConnection.SetToolTip(labelNickOfChannelToConnect, "nickname of the channel to connect to");
            // 
            // textBoxDoNotTtsIfStartWith
            // 
            textBoxDoNotTtsIfStartWith.Location = new Point(12, 518);
            textBoxDoNotTtsIfStartWith.Name = "textBoxDoNotTtsIfStartWith";
            textBoxDoNotTtsIfStartWith.Size = new Size(65, 23);
            textBoxDoNotTtsIfStartWith.TabIndex = 29;
            toolTipInfoForConnection.SetToolTip(textBoxDoNotTtsIfStartWith, "Only ONE letter!");
            textBoxDoNotTtsIfStartWith.TextChanged += textBoxDoNotTtsIfStartWith_TextChanged;
            // 
            // textBoxViewerSkipCurrentTtsMessage
            // 
            textBoxViewerSkipCurrentTtsMessage.Location = new Point(12, 440);
            textBoxViewerSkipCurrentTtsMessage.Name = "textBoxViewerSkipCurrentTtsMessage";
            textBoxViewerSkipCurrentTtsMessage.Size = new Size(65, 23);
            textBoxViewerSkipCurrentTtsMessage.TabIndex = 24;
            toolTipInfoForConnection.SetToolTip(textBoxViewerSkipCurrentTtsMessage, "With \"!\" or without");
            textBoxViewerSkipCurrentTtsMessage.TextChanged += textBoxViewerSkipCurrentTtsMessage_TextChanged;
            // 
            // textBoxViewerSkipAllQueueMessage
            // 
            textBoxViewerSkipAllQueueMessage.Location = new Point(140, 440);
            textBoxViewerSkipAllQueueMessage.Name = "textBoxViewerSkipAllQueueMessage";
            textBoxViewerSkipAllQueueMessage.Size = new Size(100, 23);
            textBoxViewerSkipAllQueueMessage.TabIndex = 28;
            toolTipInfoForConnection.SetToolTip(textBoxViewerSkipAllQueueMessage, "With \"!\" or without");
            textBoxViewerSkipAllQueueMessage.TextChanged += textBoxViewerSkipAllQueueMessage_TextChanged;
            // 
            // textBoxTestTts
            // 
            textBoxTestTts.Location = new Point(140, 496);
            textBoxTestTts.Name = "textBoxTestTts";
            textBoxTestTts.Size = new Size(100, 23);
            textBoxTestTts.TabIndex = 34;
            toolTipInfoForConnection.SetToolTip(textBoxTestTts, "Test");
            // 
            // textBoxProfileAdd
            // 
            textBoxProfileAdd.Location = new Point(309, 47);
            textBoxProfileAdd.Name = "textBoxProfileAdd";
            textBoxProfileAdd.Size = new Size(100, 23);
            textBoxProfileAdd.TabIndex = 35;
            toolTipInfoForConnection.SetToolTip(textBoxProfileAdd, "NEVER SHOW THIS ANYONE");
            // 
            // comboBoxProfileSelect
            // 
            comboBoxProfileSelect.FormattingEnabled = true;
            comboBoxProfileSelect.Location = new Point(309, 17);
            comboBoxProfileSelect.Name = "comboBoxProfileSelect";
            comboBoxProfileSelect.Size = new Size(100, 23);
            comboBoxProfileSelect.TabIndex = 36;
            toolTipInfoForConnection.SetToolTip(comboBoxProfileSelect, "Profile name");
            // 
            // labelConnectionStatus
            // 
            labelConnectionStatus.AutoSize = true;
            labelConnectionStatus.Location = new Point(12, 44);
            labelConnectionStatus.Name = "labelConnectionStatus";
            labelConnectionStatus.Size = new Size(0, 15);
            labelConnectionStatus.TabIndex = 4;
            // 
            // checkBoxClearEmoji
            // 
            checkBoxClearEmoji.AutoSize = true;
            checkBoxClearEmoji.Location = new Point(78, 102);
            checkBoxClearEmoji.Name = "checkBoxClearEmoji";
            checkBoxClearEmoji.Size = new Size(152, 19);
            checkBoxClearEmoji.TabIndex = 5;
            checkBoxClearEmoji.Text = "Remove emoji from TTS";
            checkBoxClearEmoji.UseVisualStyleBackColor = true;
            checkBoxClearEmoji.CheckedChanged += checkBoxClearEmoji_CheckedChanged;
            // 
            // comboBoxInstalledVoices
            // 
            comboBoxInstalledVoices.FormattingEnabled = true;
            comboBoxInstalledVoices.Location = new Point(78, 70);
            comboBoxInstalledVoices.Name = "comboBoxInstalledVoices";
            comboBoxInstalledVoices.Size = new Size(100, 23);
            comboBoxInstalledVoices.TabIndex = 6;
            comboBoxInstalledVoices.SelectedIndexChanged += comboBoxInstalledVoices_SelectedIndexChanged;
            // 
            // trackBarTtsVolume
            // 
            trackBarTtsVolume.Location = new Point(12, 124);
            trackBarTtsVolume.Maximum = 100;
            trackBarTtsVolume.Name = "trackBarTtsVolume";
            trackBarTtsVolume.Size = new Size(166, 45);
            trackBarTtsVolume.TabIndex = 7;
            trackBarTtsVolume.Scroll += trackBarTtsVolume_Scroll;
            trackBarTtsVolume.ValueChanged += trackBarTtsVolume_ValueChanged;
            // 
            // trackBarTtsSpeed
            // 
            trackBarTtsSpeed.LargeChange = 1;
            trackBarTtsSpeed.Location = new Point(12, 175);
            trackBarTtsSpeed.Minimum = -10;
            trackBarTtsSpeed.Name = "trackBarTtsSpeed";
            trackBarTtsSpeed.Size = new Size(166, 45);
            trackBarTtsSpeed.TabIndex = 8;
            trackBarTtsSpeed.ValueChanged += trackBarTtsSpeed_ValueChanged;
            // 
            // labelTtsVolume
            // 
            labelTtsVolume.AutoSize = true;
            labelTtsVolume.Location = new Point(184, 124);
            labelTtsVolume.Name = "labelTtsVolume";
            labelTtsVolume.Size = new Size(0, 15);
            labelTtsVolume.TabIndex = 9;
            // 
            // labelTtsSpeed
            // 
            labelTtsSpeed.AutoSize = true;
            labelTtsSpeed.Location = new Point(184, 175);
            labelTtsSpeed.Name = "labelTtsSpeed";
            labelTtsSpeed.Size = new Size(0, 15);
            labelTtsSpeed.TabIndex = 10;
            // 
            // labelBlackList
            // 
            labelBlackList.AutoSize = true;
            labelBlackList.Location = new Point(12, 205);
            labelBlackList.Name = "labelBlackList";
            labelBlackList.Size = new Size(74, 15);
            labelBlackList.TabIndex = 11;
            labelBlackList.Text = "TTS black list";
            // 
            // textBoxBlackList
            // 
            textBoxBlackList.Location = new Point(12, 226);
            textBoxBlackList.Name = "textBoxBlackList";
            textBoxBlackList.Size = new Size(100, 23);
            textBoxBlackList.TabIndex = 12;
            // 
            // listBoxBlackList
            // 
            listBoxBlackList.FormattingEnabled = true;
            listBoxBlackList.ItemHeight = 15;
            listBoxBlackList.Location = new Point(12, 255);
            listBoxBlackList.Name = "listBoxBlackList";
            listBoxBlackList.Size = new Size(100, 49);
            listBoxBlackList.TabIndex = 13;
            // 
            // buttonAddToBlackList
            // 
            buttonAddToBlackList.Location = new Point(118, 225);
            buttonAddToBlackList.Name = "buttonAddToBlackList";
            buttonAddToBlackList.Size = new Size(75, 23);
            buttonAddToBlackList.TabIndex = 14;
            buttonAddToBlackList.Text = "Add";
            buttonAddToBlackList.UseVisualStyleBackColor = true;
            buttonAddToBlackList.Click += buttonAddToBlackList_Click;
            // 
            // buttonRemoveFromBlackList
            // 
            buttonRemoveFromBlackList.Location = new Point(118, 254);
            buttonRemoveFromBlackList.Name = "buttonRemoveFromBlackList";
            buttonRemoveFromBlackList.Size = new Size(75, 50);
            buttonRemoveFromBlackList.TabIndex = 15;
            buttonRemoveFromBlackList.Text = "Remove selected";
            buttonRemoveFromBlackList.UseVisualStyleBackColor = true;
            buttonRemoveFromBlackList.Click += buttonRemoveFromBlackList_Click;
            // 
            // labelTtsVolumeName
            // 
            labelTtsVolumeName.AutoSize = true;
            labelTtsVolumeName.Location = new Point(205, 124);
            labelTtsVolumeName.Name = "labelTtsVolumeName";
            labelTtsVolumeName.Size = new Size(47, 15);
            labelTtsVolumeName.TabIndex = 16;
            labelTtsVolumeName.Text = "Volume";
            // 
            // labelTtsSpeedName
            // 
            labelTtsSpeedName.AutoSize = true;
            labelTtsSpeedName.Location = new Point(205, 175);
            labelTtsSpeedName.Name = "labelTtsSpeedName";
            labelTtsSpeedName.Size = new Size(56, 15);
            labelTtsSpeedName.TabIndex = 17;
            labelTtsSpeedName.Text = "Tts speed";
            // 
            // labelSkipMessage
            // 
            labelSkipMessage.AutoSize = true;
            labelSkipMessage.Location = new Point(12, 323);
            labelSkipMessage.Name = "labelSkipMessage";
            labelSkipMessage.Size = new Size(78, 15);
            labelSkipMessage.TabIndex = 18;
            labelSkipMessage.Text = "Skip message";
            // 
            // buttonSkipCurrentMessage
            // 
            buttonSkipCurrentMessage.Location = new Point(12, 341);
            buttonSkipCurrentMessage.Name = "buttonSkipCurrentMessage";
            buttonSkipCurrentMessage.Size = new Size(100, 23);
            buttonSkipCurrentMessage.TabIndex = 19;
            buttonSkipCurrentMessage.Text = "Skip current tts";
            buttonSkipCurrentMessage.UseVisualStyleBackColor = true;
            buttonSkipCurrentMessage.Click += buttonSkipCurrentMessage_Click;
            // 
            // buttonClearEntireQueue
            // 
            buttonClearEntireQueue.Location = new Point(118, 341);
            buttonClearEntireQueue.Name = "buttonClearEntireQueue";
            buttonClearEntireQueue.Size = new Size(55, 23);
            buttonClearEntireQueue.TabIndex = 20;
            buttonClearEntireQueue.Text = "Skip all";
            buttonClearEntireQueue.UseVisualStyleBackColor = true;
            buttonClearEntireQueue.Click += buttonClearEntireQueue_Click;
            // 
            // labelAllowViewerToSkip
            // 
            labelAllowViewerToSkip.AutoSize = true;
            labelAllowViewerToSkip.Location = new Point(12, 367);
            labelAllowViewerToSkip.Name = "labelAllowViewerToSkip";
            labelAllowViewerToSkip.Size = new Size(128, 15);
            labelAllowViewerToSkip.TabIndex = 22;
            labelAllowViewerToSkip.Text = "Allow viewer to skip tts";
            // 
            // labelViewerSkipCurrent
            // 
            labelViewerSkipCurrent.AutoSize = true;
            labelViewerSkipCurrent.Location = new Point(78, 391);
            labelViewerSkipCurrent.Name = "labelViewerSkipCurrent";
            labelViewerSkipCurrent.Size = new Size(145, 15);
            labelViewerSkipCurrent.TabIndex = 25;
            labelViewerSkipCurrent.Text = "leave blank if not skipping";
            // 
            // labelViewerSkipCurrentMessage
            // 
            labelViewerSkipCurrentMessage.AutoSize = true;
            labelViewerSkipCurrentMessage.Location = new Point(12, 422);
            labelViewerSkipCurrentMessage.Name = "labelViewerSkipCurrentMessage";
            labelViewerSkipCurrentMessage.Size = new Size(65, 15);
            labelViewerSkipCurrentMessage.TabIndex = 26;
            labelViewerSkipCurrentMessage.Text = "Current Tts";
            // 
            // labelViewerSkipAllQueue
            // 
            labelViewerSkipAllQueue.AutoSize = true;
            labelViewerSkipAllQueue.Location = new Point(140, 422);
            labelViewerSkipAllQueue.Name = "labelViewerSkipAllQueue";
            labelViewerSkipAllQueue.Size = new Size(121, 15);
            labelViewerSkipAllQueue.TabIndex = 27;
            labelViewerSkipAllQueue.Text = "Current and all queue";
            // 
            // labelDoNotTtsIfStartWith
            // 
            labelDoNotTtsIfStartWith.AutoSize = true;
            labelDoNotTtsIfStartWith.Location = new Point(12, 500);
            labelDoNotTtsIfStartWith.Name = "labelDoNotTtsIfStartWith";
            labelDoNotTtsIfStartWith.Size = new Size(121, 15);
            labelDoNotTtsIfStartWith.TabIndex = 30;
            labelDoNotTtsIfStartWith.Text = "Do not tts if start with";
            // 
            // labelTtsTest
            // 
            labelTtsTest.AutoSize = true;
            labelTtsTest.Location = new Point(140, 478);
            labelTtsTest.Name = "labelTtsTest";
            labelTtsTest.Size = new Size(44, 15);
            labelTtsTest.TabIndex = 32;
            labelTtsTest.Text = "Tts test";
            // 
            // buttonTestTts
            // 
            buttonTestTts.Location = new Point(140, 522);
            buttonTestTts.Name = "buttonTestTts";
            buttonTestTts.Size = new Size(44, 23);
            buttonTestTts.TabIndex = 33;
            buttonTestTts.Text = "Say it";
            buttonTestTts.UseVisualStyleBackColor = true;
            buttonTestTts.Click += buttonTestTts_Click;
            // 
            // buttonProfileAdd
            // 
            buttonProfileAdd.Location = new Point(309, 76);
            buttonProfileAdd.Name = "buttonProfileAdd";
            buttonProfileAdd.Size = new Size(100, 23);
            buttonProfileAdd.TabIndex = 37;
            buttonProfileAdd.Text = "Save profile";
            buttonProfileAdd.UseVisualStyleBackColor = true;
            buttonProfileAdd.Click += buttonProfileAdd_Click;
            // 
            // buttonProfileLoad
            // 
            buttonProfileLoad.Location = new Point(415, 16);
            buttonProfileLoad.Name = "buttonProfileLoad";
            buttonProfileLoad.Size = new Size(78, 23);
            buttonProfileLoad.TabIndex = 38;
            buttonProfileLoad.Text = "Load profile";
            buttonProfileLoad.UseVisualStyleBackColor = true;
            buttonProfileLoad.Click += buttonProfileLoad_Click;
            // 
            // button
            // 
            button.Location = new Point(309, 111);
            button.Name = "button";
            button.Size = new Size(100, 23);
            button.TabIndex = 39;
            button.Text = "Delete profile";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // labelProfileAdd
            // 
            labelProfileAdd.AutoSize = true;
            labelProfileAdd.Location = new Point(257, 16);
            labelProfileAdd.Name = "labelProfileAdd";
            labelProfileAdd.Size = new Size(46, 15);
            labelProfileAdd.TabIndex = 40;
            labelProfileAdd.Text = "Profiles";
            // 
            // labelProfileDelete
            // 
            labelProfileDelete.AutoSize = true;
            labelProfileDelete.Location = new Point(254, 46);
            labelProfileDelete.MaximumSize = new Size(50, 0);
            labelProfileDelete.Name = "labelProfileDelete";
            labelProfileDelete.Size = new Size(49, 45);
            labelProfileDelete.TabIndex = 41;
            labelProfileDelete.Text = "Profiles add or delete";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 549);
            Controls.Add(labelProfileDelete);
            Controls.Add(labelProfileAdd);
            Controls.Add(button);
            Controls.Add(buttonProfileLoad);
            Controls.Add(buttonProfileAdd);
            Controls.Add(comboBoxProfileSelect);
            Controls.Add(textBoxProfileAdd);
            Controls.Add(textBoxTestTts);
            Controls.Add(buttonTestTts);
            Controls.Add(labelTtsTest);
            Controls.Add(labelDoNotTtsIfStartWith);
            Controls.Add(textBoxDoNotTtsIfStartWith);
            Controls.Add(textBoxViewerSkipAllQueueMessage);
            Controls.Add(labelViewerSkipAllQueue);
            Controls.Add(labelViewerSkipCurrentMessage);
            Controls.Add(labelViewerSkipCurrent);
            Controls.Add(textBoxViewerSkipCurrentTtsMessage);
            Controls.Add(labelAllowViewerToSkip);
            Controls.Add(labelNickOfChannelToConnect);
            Controls.Add(buttonClearEntireQueue);
            Controls.Add(buttonSkipCurrentMessage);
            Controls.Add(labelSkipMessage);
            Controls.Add(labelTtsSpeedName);
            Controls.Add(labelTtsVolumeName);
            Controls.Add(buttonRemoveFromBlackList);
            Controls.Add(buttonAddToBlackList);
            Controls.Add(listBoxBlackList);
            Controls.Add(textBoxBlackList);
            Controls.Add(labelBlackList);
            Controls.Add(labelTtsSpeed);
            Controls.Add(labelTtsVolume);
            Controls.Add(trackBarTtsSpeed);
            Controls.Add(trackBarTtsVolume);
            Controls.Add(comboBoxInstalledVoices);
            Controls.Add(checkBoxClearEmoji);
            Controls.Add(labelConnectionStatus);
            Controls.Add(linkLabelTwitchApi);
            Controls.Add(textBoxTwitchNick);
            Controls.Add(textBoxTwitchApi);
            Controls.Add(buttonTwitchConnect);
            Name = "MainWindow";
            Text = "SimpleTwitchTts v1.0";
            FormClosing += MainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarTtsVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTtsSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTwitchConnect;
        private TextBox textBoxTwitchApi;
        private TextBox textBoxTwitchNick;
        private LinkLabel linkLabelTwitchApi;
        private ToolTip toolTipInfoForConnection;
        public Label labelConnectionStatus;
        private CheckBox checkBoxClearEmoji;
        private ComboBox comboBoxInstalledVoices;
        private TrackBar trackBarTtsVolume;
        private TrackBar trackBarTtsSpeed;
        private Label labelTtsVolume;
        private Label labelTtsSpeed;
        private Label labelBlackList;
        private TextBox textBoxBlackList;
        private ListBox listBoxBlackList;
        private Button buttonAddToBlackList;
        private Button buttonRemoveFromBlackList;
        private Label labelTtsVolumeName;
        private Label labelTtsSpeedName;
        private Label labelSkipMessage;
        private Button buttonSkipCurrentMessage;
        private Button buttonClearEntireQueue;
        private Label labelNickOfChannelToConnect;
        private Label labelAllowViewerToSkip;
        private TextBox textBoxViewerSkipCurrentTtsMessage;
        private Label labelViewerSkipCurrent;
        private Label labelViewerSkipCurrentMessage;
        private Label labelViewerSkipAllQueue;
        private TextBox textBoxViewerSkipAllQueueMessage;
        private TextBox textBoxDoNotTtsIfStartWith;
        private Label labelDoNotTtsIfStartWith;
        private Label labelTtsTest;
        private Button buttonTestTts;
        private TextBox textBoxTestTts;
        private TextBox textBoxProfileAdd;
        private ComboBox comboBoxProfileSelect;
        private Button buttonProfileAdd;
        private Button buttonProfileLoad;
        private Button button;
        private Label labelProfileAdd;
        private Label labelProfileDelete;
    }
}