﻿namespace SimpleTwitchTTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            buttonProfileLoad = new Button();
            buttonProfileDeleteEN = new Button();
            labelProfileAdd = new Label();
            labelProfileDelete = new Label();
            buttonLanguageChange = new Button();
            buttonOpenFolderRU = new Button();
            buttonProfileSave = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarTtsVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarTtsSpeed).BeginInit();
            SuspendLayout();
            // 
            // buttonTwitchConnect
            // 
            resources.ApplyResources(buttonTwitchConnect, "buttonTwitchConnect");
            buttonTwitchConnect.Name = "buttonTwitchConnect";
            toolTipInfoForConnection.SetToolTip(buttonTwitchConnect, resources.GetString("buttonTwitchConnect.ToolTip"));
            buttonTwitchConnect.UseVisualStyleBackColor = true;
            buttonTwitchConnect.Click += buttonTwitchConnect_Click;
            // 
            // textBoxTwitchApi
            // 
            resources.ApplyResources(textBoxTwitchApi, "textBoxTwitchApi");
            textBoxTwitchApi.Name = "textBoxTwitchApi";
            toolTipInfoForConnection.SetToolTip(textBoxTwitchApi, resources.GetString("textBoxTwitchApi.ToolTip"));
            textBoxTwitchApi.TextChanged += textBoxTwitchApi_TextChanged;
            // 
            // textBoxTwitchNick
            // 
            resources.ApplyResources(textBoxTwitchNick, "textBoxTwitchNick");
            textBoxTwitchNick.Name = "textBoxTwitchNick";
            toolTipInfoForConnection.SetToolTip(textBoxTwitchNick, resources.GetString("textBoxTwitchNick.ToolTip"));
            // 
            // linkLabelTwitchApi
            // 
            resources.ApplyResources(linkLabelTwitchApi, "linkLabelTwitchApi");
            linkLabelTwitchApi.Name = "linkLabelTwitchApi";
            linkLabelTwitchApi.TabStop = true;
            toolTipInfoForConnection.SetToolTip(linkLabelTwitchApi, resources.GetString("linkLabelTwitchApi.ToolTip"));
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
            resources.ApplyResources(labelNickOfChannelToConnect, "labelNickOfChannelToConnect");
            labelNickOfChannelToConnect.Name = "labelNickOfChannelToConnect";
            toolTipInfoForConnection.SetToolTip(labelNickOfChannelToConnect, resources.GetString("labelNickOfChannelToConnect.ToolTip"));
            // 
            // textBoxDoNotTtsIfStartWith
            // 
            resources.ApplyResources(textBoxDoNotTtsIfStartWith, "textBoxDoNotTtsIfStartWith");
            textBoxDoNotTtsIfStartWith.Name = "textBoxDoNotTtsIfStartWith";
            toolTipInfoForConnection.SetToolTip(textBoxDoNotTtsIfStartWith, resources.GetString("textBoxDoNotTtsIfStartWith.ToolTip"));
            textBoxDoNotTtsIfStartWith.TextChanged += textBoxDoNotTtsIfStartWith_TextChanged;
            // 
            // textBoxViewerSkipCurrentTtsMessage
            // 
            resources.ApplyResources(textBoxViewerSkipCurrentTtsMessage, "textBoxViewerSkipCurrentTtsMessage");
            textBoxViewerSkipCurrentTtsMessage.Name = "textBoxViewerSkipCurrentTtsMessage";
            toolTipInfoForConnection.SetToolTip(textBoxViewerSkipCurrentTtsMessage, resources.GetString("textBoxViewerSkipCurrentTtsMessage.ToolTip"));
            textBoxViewerSkipCurrentTtsMessage.TextChanged += textBoxViewerSkipCurrentTtsMessage_TextChanged;
            // 
            // textBoxViewerSkipAllQueueMessage
            // 
            resources.ApplyResources(textBoxViewerSkipAllQueueMessage, "textBoxViewerSkipAllQueueMessage");
            textBoxViewerSkipAllQueueMessage.Name = "textBoxViewerSkipAllQueueMessage";
            toolTipInfoForConnection.SetToolTip(textBoxViewerSkipAllQueueMessage, resources.GetString("textBoxViewerSkipAllQueueMessage.ToolTip"));
            textBoxViewerSkipAllQueueMessage.TextChanged += textBoxViewerSkipAllQueueMessage_TextChanged;
            // 
            // textBoxTestTts
            // 
            resources.ApplyResources(textBoxTestTts, "textBoxTestTts");
            textBoxTestTts.Name = "textBoxTestTts";
            toolTipInfoForConnection.SetToolTip(textBoxTestTts, resources.GetString("textBoxTestTts.ToolTip"));
            // 
            // textBoxProfileAdd
            // 
            resources.ApplyResources(textBoxProfileAdd, "textBoxProfileAdd");
            textBoxProfileAdd.Name = "textBoxProfileAdd";
            toolTipInfoForConnection.SetToolTip(textBoxProfileAdd, resources.GetString("textBoxProfileAdd.ToolTip"));
            // 
            // comboBoxProfileSelect
            // 
            resources.ApplyResources(comboBoxProfileSelect, "comboBoxProfileSelect");
            comboBoxProfileSelect.FormattingEnabled = true;
            comboBoxProfileSelect.Name = "comboBoxProfileSelect";
            toolTipInfoForConnection.SetToolTip(comboBoxProfileSelect, resources.GetString("comboBoxProfileSelect.ToolTip"));
            // 
            // labelConnectionStatus
            // 
            resources.ApplyResources(labelConnectionStatus, "labelConnectionStatus");
            labelConnectionStatus.Name = "labelConnectionStatus";
            toolTipInfoForConnection.SetToolTip(labelConnectionStatus, resources.GetString("labelConnectionStatus.ToolTip"));
            // 
            // checkBoxClearEmoji
            // 
            resources.ApplyResources(checkBoxClearEmoji, "checkBoxClearEmoji");
            checkBoxClearEmoji.Name = "checkBoxClearEmoji";
            toolTipInfoForConnection.SetToolTip(checkBoxClearEmoji, resources.GetString("checkBoxClearEmoji.ToolTip"));
            checkBoxClearEmoji.UseVisualStyleBackColor = true;
            checkBoxClearEmoji.CheckedChanged += checkBoxClearEmoji_CheckedChanged;
            // 
            // comboBoxInstalledVoices
            // 
            resources.ApplyResources(comboBoxInstalledVoices, "comboBoxInstalledVoices");
            comboBoxInstalledVoices.FormattingEnabled = true;
            comboBoxInstalledVoices.Name = "comboBoxInstalledVoices";
            toolTipInfoForConnection.SetToolTip(comboBoxInstalledVoices, resources.GetString("comboBoxInstalledVoices.ToolTip"));
            comboBoxInstalledVoices.SelectedIndexChanged += comboBoxInstalledVoices_SelectedIndexChanged;
            // 
            // trackBarTtsVolume
            // 
            resources.ApplyResources(trackBarTtsVolume, "trackBarTtsVolume");
            trackBarTtsVolume.Maximum = 100;
            trackBarTtsVolume.Name = "trackBarTtsVolume";
            toolTipInfoForConnection.SetToolTip(trackBarTtsVolume, resources.GetString("trackBarTtsVolume.ToolTip"));
            trackBarTtsVolume.Scroll += trackBarTtsVolume_Scroll;
            trackBarTtsVolume.ValueChanged += trackBarTtsVolume_ValueChanged;
            // 
            // trackBarTtsSpeed
            // 
            resources.ApplyResources(trackBarTtsSpeed, "trackBarTtsSpeed");
            trackBarTtsSpeed.LargeChange = 1;
            trackBarTtsSpeed.Minimum = -10;
            trackBarTtsSpeed.Name = "trackBarTtsSpeed";
            toolTipInfoForConnection.SetToolTip(trackBarTtsSpeed, resources.GetString("trackBarTtsSpeed.ToolTip"));
            trackBarTtsSpeed.ValueChanged += trackBarTtsSpeed_ValueChanged;
            // 
            // labelTtsVolume
            // 
            resources.ApplyResources(labelTtsVolume, "labelTtsVolume");
            labelTtsVolume.Name = "labelTtsVolume";
            toolTipInfoForConnection.SetToolTip(labelTtsVolume, resources.GetString("labelTtsVolume.ToolTip"));
            // 
            // labelTtsSpeed
            // 
            resources.ApplyResources(labelTtsSpeed, "labelTtsSpeed");
            labelTtsSpeed.Name = "labelTtsSpeed";
            toolTipInfoForConnection.SetToolTip(labelTtsSpeed, resources.GetString("labelTtsSpeed.ToolTip"));
            // 
            // labelBlackList
            // 
            resources.ApplyResources(labelBlackList, "labelBlackList");
            labelBlackList.Name = "labelBlackList";
            toolTipInfoForConnection.SetToolTip(labelBlackList, resources.GetString("labelBlackList.ToolTip"));
            // 
            // textBoxBlackList
            // 
            resources.ApplyResources(textBoxBlackList, "textBoxBlackList");
            textBoxBlackList.Name = "textBoxBlackList";
            toolTipInfoForConnection.SetToolTip(textBoxBlackList, resources.GetString("textBoxBlackList.ToolTip"));
            // 
            // listBoxBlackList
            // 
            resources.ApplyResources(listBoxBlackList, "listBoxBlackList");
            listBoxBlackList.FormattingEnabled = true;
            listBoxBlackList.Name = "listBoxBlackList";
            toolTipInfoForConnection.SetToolTip(listBoxBlackList, resources.GetString("listBoxBlackList.ToolTip"));
            // 
            // buttonAddToBlackList
            // 
            resources.ApplyResources(buttonAddToBlackList, "buttonAddToBlackList");
            buttonAddToBlackList.Name = "buttonAddToBlackList";
            toolTipInfoForConnection.SetToolTip(buttonAddToBlackList, resources.GetString("buttonAddToBlackList.ToolTip"));
            buttonAddToBlackList.UseVisualStyleBackColor = true;
            buttonAddToBlackList.Click += buttonAddToBlackList_Click;
            // 
            // buttonRemoveFromBlackList
            // 
            resources.ApplyResources(buttonRemoveFromBlackList, "buttonRemoveFromBlackList");
            buttonRemoveFromBlackList.Name = "buttonRemoveFromBlackList";
            toolTipInfoForConnection.SetToolTip(buttonRemoveFromBlackList, resources.GetString("buttonRemoveFromBlackList.ToolTip"));
            buttonRemoveFromBlackList.UseVisualStyleBackColor = true;
            buttonRemoveFromBlackList.Click += buttonRemoveFromBlackList_Click;
            // 
            // labelTtsVolumeName
            // 
            resources.ApplyResources(labelTtsVolumeName, "labelTtsVolumeName");
            labelTtsVolumeName.Name = "labelTtsVolumeName";
            toolTipInfoForConnection.SetToolTip(labelTtsVolumeName, resources.GetString("labelTtsVolumeName.ToolTip"));
            // 
            // labelTtsSpeedName
            // 
            resources.ApplyResources(labelTtsSpeedName, "labelTtsSpeedName");
            labelTtsSpeedName.Name = "labelTtsSpeedName";
            toolTipInfoForConnection.SetToolTip(labelTtsSpeedName, resources.GetString("labelTtsSpeedName.ToolTip"));
            // 
            // labelSkipMessage
            // 
            resources.ApplyResources(labelSkipMessage, "labelSkipMessage");
            labelSkipMessage.Name = "labelSkipMessage";
            toolTipInfoForConnection.SetToolTip(labelSkipMessage, resources.GetString("labelSkipMessage.ToolTip"));
            // 
            // buttonSkipCurrentMessage
            // 
            resources.ApplyResources(buttonSkipCurrentMessage, "buttonSkipCurrentMessage");
            buttonSkipCurrentMessage.Name = "buttonSkipCurrentMessage";
            toolTipInfoForConnection.SetToolTip(buttonSkipCurrentMessage, resources.GetString("buttonSkipCurrentMessage.ToolTip"));
            buttonSkipCurrentMessage.UseVisualStyleBackColor = true;
            buttonSkipCurrentMessage.Click += buttonSkipCurrentMessage_Click;
            // 
            // buttonClearEntireQueue
            // 
            resources.ApplyResources(buttonClearEntireQueue, "buttonClearEntireQueue");
            buttonClearEntireQueue.Name = "buttonClearEntireQueue";
            toolTipInfoForConnection.SetToolTip(buttonClearEntireQueue, resources.GetString("buttonClearEntireQueue.ToolTip"));
            buttonClearEntireQueue.UseVisualStyleBackColor = true;
            buttonClearEntireQueue.Click += buttonClearEntireQueue_Click;
            // 
            // labelAllowViewerToSkip
            // 
            resources.ApplyResources(labelAllowViewerToSkip, "labelAllowViewerToSkip");
            labelAllowViewerToSkip.Name = "labelAllowViewerToSkip";
            toolTipInfoForConnection.SetToolTip(labelAllowViewerToSkip, resources.GetString("labelAllowViewerToSkip.ToolTip"));
            // 
            // labelViewerSkipCurrent
            // 
            resources.ApplyResources(labelViewerSkipCurrent, "labelViewerSkipCurrent");
            labelViewerSkipCurrent.Name = "labelViewerSkipCurrent";
            toolTipInfoForConnection.SetToolTip(labelViewerSkipCurrent, resources.GetString("labelViewerSkipCurrent.ToolTip"));
            // 
            // labelViewerSkipCurrentMessage
            // 
            resources.ApplyResources(labelViewerSkipCurrentMessage, "labelViewerSkipCurrentMessage");
            labelViewerSkipCurrentMessage.Name = "labelViewerSkipCurrentMessage";
            toolTipInfoForConnection.SetToolTip(labelViewerSkipCurrentMessage, resources.GetString("labelViewerSkipCurrentMessage.ToolTip"));
            // 
            // labelViewerSkipAllQueue
            // 
            resources.ApplyResources(labelViewerSkipAllQueue, "labelViewerSkipAllQueue");
            labelViewerSkipAllQueue.Name = "labelViewerSkipAllQueue";
            toolTipInfoForConnection.SetToolTip(labelViewerSkipAllQueue, resources.GetString("labelViewerSkipAllQueue.ToolTip"));
            // 
            // labelDoNotTtsIfStartWith
            // 
            resources.ApplyResources(labelDoNotTtsIfStartWith, "labelDoNotTtsIfStartWith");
            labelDoNotTtsIfStartWith.Name = "labelDoNotTtsIfStartWith";
            toolTipInfoForConnection.SetToolTip(labelDoNotTtsIfStartWith, resources.GetString("labelDoNotTtsIfStartWith.ToolTip"));
            // 
            // labelTtsTest
            // 
            resources.ApplyResources(labelTtsTest, "labelTtsTest");
            labelTtsTest.Name = "labelTtsTest";
            toolTipInfoForConnection.SetToolTip(labelTtsTest, resources.GetString("labelTtsTest.ToolTip"));
            // 
            // buttonTestTts
            // 
            resources.ApplyResources(buttonTestTts, "buttonTestTts");
            buttonTestTts.Name = "buttonTestTts";
            toolTipInfoForConnection.SetToolTip(buttonTestTts, resources.GetString("buttonTestTts.ToolTip"));
            buttonTestTts.UseVisualStyleBackColor = true;
            buttonTestTts.Click += buttonTestTts_Click;
            // 
            // buttonProfileLoad
            // 
            resources.ApplyResources(buttonProfileLoad, "buttonProfileLoad");
            buttonProfileLoad.Name = "buttonProfileLoad";
            toolTipInfoForConnection.SetToolTip(buttonProfileLoad, resources.GetString("buttonProfileLoad.ToolTip"));
            buttonProfileLoad.UseVisualStyleBackColor = true;
            buttonProfileLoad.Click += buttonProfileLoad_Click;
            // 
            // buttonProfileDeleteEN
            // 
            resources.ApplyResources(buttonProfileDeleteEN, "buttonProfileDeleteEN");
            buttonProfileDeleteEN.Name = "buttonProfileDeleteEN";
            toolTipInfoForConnection.SetToolTip(buttonProfileDeleteEN, resources.GetString("buttonProfileDeleteEN.ToolTip"));
            buttonProfileDeleteEN.UseVisualStyleBackColor = true;
            buttonProfileDeleteEN.Click += buttonProfileDelete;
            // 
            // labelProfileAdd
            // 
            resources.ApplyResources(labelProfileAdd, "labelProfileAdd");
            labelProfileAdd.Name = "labelProfileAdd";
            toolTipInfoForConnection.SetToolTip(labelProfileAdd, resources.GetString("labelProfileAdd.ToolTip"));
            // 
            // labelProfileDelete
            // 
            resources.ApplyResources(labelProfileDelete, "labelProfileDelete");
            labelProfileDelete.Name = "labelProfileDelete";
            toolTipInfoForConnection.SetToolTip(labelProfileDelete, resources.GetString("labelProfileDelete.ToolTip"));
            // 
            // buttonLanguageChange
            // 
            resources.ApplyResources(buttonLanguageChange, "buttonLanguageChange");
            buttonLanguageChange.Name = "buttonLanguageChange";
            toolTipInfoForConnection.SetToolTip(buttonLanguageChange, resources.GetString("buttonLanguageChange.ToolTip"));
            buttonLanguageChange.UseVisualStyleBackColor = true;
            buttonLanguageChange.Click += buttonLanguageChange_Click;
            // 
            // buttonOpenFolderRU
            // 
            resources.ApplyResources(buttonOpenFolderRU, "buttonOpenFolderRU");
            buttonOpenFolderRU.Name = "buttonOpenFolderRU";
            toolTipInfoForConnection.SetToolTip(buttonOpenFolderRU, resources.GetString("buttonOpenFolderRU.ToolTip"));
            buttonOpenFolderRU.UseVisualStyleBackColor = true;
            buttonOpenFolderRU.Click += buttonProfileOpenFolder;
            // 
            // buttonProfileSave
            // 
            resources.ApplyResources(buttonProfileSave, "buttonProfileSave");
            buttonProfileSave.Name = "buttonProfileSave";
            toolTipInfoForConnection.SetToolTip(buttonProfileSave, resources.GetString("buttonProfileSave.ToolTip"));
            buttonProfileSave.UseVisualStyleBackColor = true;
            buttonProfileSave.Click += buttonProfileAddClick;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonProfileSave);
            Controls.Add(buttonOpenFolderRU);
            Controls.Add(buttonLanguageChange);
            Controls.Add(labelProfileDelete);
            Controls.Add(labelProfileAdd);
            Controls.Add(buttonProfileDeleteEN);
            Controls.Add(buttonProfileLoad);
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
            toolTipInfoForConnection.SetToolTip(this, resources.GetString("$this.ToolTip"));
            FormClosing += MainWindow_FormClosing;
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
        private Button buttonProfileLoad;
        private Button buttonProfileDeleteEN;
        private Label labelProfileAdd;
        private Label labelProfileDelete;
        private Button buttonLanguageChange;
        //private Button buttonProfileOpenFolder;
        private Button buttonOpenFolderRU;
        private Button buttonProfileSave;
    }
}