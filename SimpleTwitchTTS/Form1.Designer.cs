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
            buttonTestTtsSkip = new Button();
            labelTypeOfMessageTts = new Label();
            comboBoxTypeOfMessageTts = new ComboBox();
            textBoxHighlightedMessageName = new TextBox();
            labelHighlightedMessageTts = new Label();
            textBoxTwitchClientID = new TextBox();
            textBoxTtsWhatToReplace = new TextBox();
            textBoxTtsSubstitute = new TextBox();
            listBoxTtsWhatToReplace = new ListBox();
            listBoxTtsSubstitute = new ListBox();
            buttonTtsTextReplace = new Button();
            buttonDeleteReplaceAndSubstitude = new Button();
            labelAnecdotChatCommand = new Label();
            textBoxAnecdotChannelPoints = new TextBox();
            labelAnecdotChannelPoints = new Label();
            textBoxAnecdotChatCommand = new TextBox();
            labelAnecdot = new Label();
            label1 = new Label();
            labelTwitchClientId = new Label();
            checkBoxOverAllWindows = new CheckBox();
            labelAnecdotsFromFiles = new Label();
            labelAnecdotsFromFilesChatCommand = new Label();
            textBoxAnecdotsFromFilesChatCommand = new TextBox();
            labelAnecdotsFromFilesChannelPointsCommand = new Label();
            textBoxAnecdotsFromFilesChannelPoints = new TextBox();
            linkLabel1 = new LinkLabel();
            labelVersionOfProgram = new Label();
            buttonAnecdotsFromFilesAddFile = new Button();
            listBoxAnecdotsFromFilesLoadedFiles = new ListBox();
            listBoxAnecdotsFromFilesAllFilesFromFolder = new ListBox();
            labelAnecdotsFromFilesAllFilesFromFolder = new Label();
            labelAnecdotsFromFilesLoadedFiles = new Label();
            buttonAnecdotsFromFilesDeleteFile = new Button();
            linkLabelKnownTroubles = new LinkLabel();
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
            toolTipInfoForConnection.IsBalloon = true;
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
            // buttonTestTtsSkip
            // 
            resources.ApplyResources(buttonTestTtsSkip, "buttonTestTtsSkip");
            buttonTestTtsSkip.Name = "buttonTestTtsSkip";
            toolTipInfoForConnection.SetToolTip(buttonTestTtsSkip, resources.GetString("buttonTestTtsSkip.ToolTip"));
            buttonTestTtsSkip.UseVisualStyleBackColor = true;
            buttonTestTtsSkip.Click += buttonTestTtsSkip_Click;
            // 
            // labelTypeOfMessageTts
            // 
            resources.ApplyResources(labelTypeOfMessageTts, "labelTypeOfMessageTts");
            labelTypeOfMessageTts.Name = "labelTypeOfMessageTts";
            toolTipInfoForConnection.SetToolTip(labelTypeOfMessageTts, resources.GetString("labelTypeOfMessageTts.ToolTip"));
            // 
            // comboBoxTypeOfMessageTts
            // 
            resources.ApplyResources(comboBoxTypeOfMessageTts, "comboBoxTypeOfMessageTts");
            comboBoxTypeOfMessageTts.FormattingEnabled = true;
            comboBoxTypeOfMessageTts.Items.AddRange(new object[] { resources.GetString("comboBoxTypeOfMessageTts.Items"), resources.GetString("comboBoxTypeOfMessageTts.Items1"), resources.GetString("comboBoxTypeOfMessageTts.Items2"), resources.GetString("comboBoxTypeOfMessageTts.Items3") });
            comboBoxTypeOfMessageTts.Name = "comboBoxTypeOfMessageTts";
            toolTipInfoForConnection.SetToolTip(comboBoxTypeOfMessageTts, resources.GetString("comboBoxTypeOfMessageTts.ToolTip"));
            comboBoxTypeOfMessageTts.SelectedIndexChanged += comboBoxTypeOfMessageTts_SelectedIndexChanged;
            // 
            // textBoxHighlightedMessageName
            // 
            resources.ApplyResources(textBoxHighlightedMessageName, "textBoxHighlightedMessageName");
            textBoxHighlightedMessageName.Name = "textBoxHighlightedMessageName";
            toolTipInfoForConnection.SetToolTip(textBoxHighlightedMessageName, resources.GetString("textBoxHighlightedMessageName.ToolTip"));
            textBoxHighlightedMessageName.TextChanged += textBoxHighlightedMessageName_TextChanged;
            // 
            // labelHighlightedMessageTts
            // 
            resources.ApplyResources(labelHighlightedMessageTts, "labelHighlightedMessageTts");
            labelHighlightedMessageTts.Name = "labelHighlightedMessageTts";
            toolTipInfoForConnection.SetToolTip(labelHighlightedMessageTts, resources.GetString("labelHighlightedMessageTts.ToolTip"));
            // 
            // textBoxTwitchClientID
            // 
            resources.ApplyResources(textBoxTwitchClientID, "textBoxTwitchClientID");
            textBoxTwitchClientID.Name = "textBoxTwitchClientID";
            toolTipInfoForConnection.SetToolTip(textBoxTwitchClientID, resources.GetString("textBoxTwitchClientID.ToolTip"));
            textBoxTwitchClientID.TextChanged += textBoxTwitchToken_TextChanged;
            // 
            // textBoxTtsWhatToReplace
            // 
            resources.ApplyResources(textBoxTtsWhatToReplace, "textBoxTtsWhatToReplace");
            textBoxTtsWhatToReplace.Name = "textBoxTtsWhatToReplace";
            toolTipInfoForConnection.SetToolTip(textBoxTtsWhatToReplace, resources.GetString("textBoxTtsWhatToReplace.ToolTip"));
            // 
            // textBoxTtsSubstitute
            // 
            resources.ApplyResources(textBoxTtsSubstitute, "textBoxTtsSubstitute");
            textBoxTtsSubstitute.Name = "textBoxTtsSubstitute";
            toolTipInfoForConnection.SetToolTip(textBoxTtsSubstitute, resources.GetString("textBoxTtsSubstitute.ToolTip"));
            // 
            // listBoxTtsWhatToReplace
            // 
            resources.ApplyResources(listBoxTtsWhatToReplace, "listBoxTtsWhatToReplace");
            listBoxTtsWhatToReplace.FormattingEnabled = true;
            listBoxTtsWhatToReplace.Name = "listBoxTtsWhatToReplace";
            toolTipInfoForConnection.SetToolTip(listBoxTtsWhatToReplace, resources.GetString("listBoxTtsWhatToReplace.ToolTip"));
            listBoxTtsWhatToReplace.SelectedValueChanged += listBoxTtsWhatToReplace_SelectedValueChanged;
            // 
            // listBoxTtsSubstitute
            // 
            resources.ApplyResources(listBoxTtsSubstitute, "listBoxTtsSubstitute");
            listBoxTtsSubstitute.FormattingEnabled = true;
            listBoxTtsSubstitute.Name = "listBoxTtsSubstitute";
            toolTipInfoForConnection.SetToolTip(listBoxTtsSubstitute, resources.GetString("listBoxTtsSubstitute.ToolTip"));
            listBoxTtsSubstitute.SelectedIndexChanged += listBoxTtsSubstitute_SelectedIndexChanged;
            // 
            // buttonTtsTextReplace
            // 
            resources.ApplyResources(buttonTtsTextReplace, "buttonTtsTextReplace");
            buttonTtsTextReplace.Name = "buttonTtsTextReplace";
            toolTipInfoForConnection.SetToolTip(buttonTtsTextReplace, resources.GetString("buttonTtsTextReplace.ToolTip"));
            buttonTtsTextReplace.UseVisualStyleBackColor = true;
            buttonTtsTextReplace.Click += buttonTtsTextReplace_Click;
            // 
            // buttonDeleteReplaceAndSubstitude
            // 
            resources.ApplyResources(buttonDeleteReplaceAndSubstitude, "buttonDeleteReplaceAndSubstitude");
            buttonDeleteReplaceAndSubstitude.Name = "buttonDeleteReplaceAndSubstitude";
            toolTipInfoForConnection.SetToolTip(buttonDeleteReplaceAndSubstitude, resources.GetString("buttonDeleteReplaceAndSubstitude.ToolTip"));
            buttonDeleteReplaceAndSubstitude.UseVisualStyleBackColor = true;
            buttonDeleteReplaceAndSubstitude.Click += buttonDeleteReplaceAndSubstitude_Click;
            // 
            // labelAnecdotChatCommand
            // 
            resources.ApplyResources(labelAnecdotChatCommand, "labelAnecdotChatCommand");
            labelAnecdotChatCommand.Name = "labelAnecdotChatCommand";
            toolTipInfoForConnection.SetToolTip(labelAnecdotChatCommand, resources.GetString("labelAnecdotChatCommand.ToolTip"));
            // 
            // textBoxAnecdotChannelPoints
            // 
            resources.ApplyResources(textBoxAnecdotChannelPoints, "textBoxAnecdotChannelPoints");
            textBoxAnecdotChannelPoints.Name = "textBoxAnecdotChannelPoints";
            toolTipInfoForConnection.SetToolTip(textBoxAnecdotChannelPoints, resources.GetString("textBoxAnecdotChannelPoints.ToolTip"));
            textBoxAnecdotChannelPoints.TextChanged += textBoxAnecdotChannelPoints_TextChanged;
            // 
            // labelAnecdotChannelPoints
            // 
            resources.ApplyResources(labelAnecdotChannelPoints, "labelAnecdotChannelPoints");
            labelAnecdotChannelPoints.Name = "labelAnecdotChannelPoints";
            toolTipInfoForConnection.SetToolTip(labelAnecdotChannelPoints, resources.GetString("labelAnecdotChannelPoints.ToolTip"));
            // 
            // textBoxAnecdotChatCommand
            // 
            resources.ApplyResources(textBoxAnecdotChatCommand, "textBoxAnecdotChatCommand");
            textBoxAnecdotChatCommand.Name = "textBoxAnecdotChatCommand";
            toolTipInfoForConnection.SetToolTip(textBoxAnecdotChatCommand, resources.GetString("textBoxAnecdotChatCommand.ToolTip"));
            textBoxAnecdotChatCommand.TextChanged += textBoxAnecdotChatCommand_TextChanged;
            // 
            // labelAnecdot
            // 
            resources.ApplyResources(labelAnecdot, "labelAnecdot");
            labelAnecdot.Name = "labelAnecdot";
            toolTipInfoForConnection.SetToolTip(labelAnecdot, resources.GetString("labelAnecdot.ToolTip"));
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            toolTipInfoForConnection.SetToolTip(label1, resources.GetString("label1.ToolTip"));
            // 
            // labelTwitchClientId
            // 
            resources.ApplyResources(labelTwitchClientId, "labelTwitchClientId");
            labelTwitchClientId.Name = "labelTwitchClientId";
            toolTipInfoForConnection.SetToolTip(labelTwitchClientId, resources.GetString("labelTwitchClientId.ToolTip"));
            // 
            // checkBoxOverAllWindows
            // 
            resources.ApplyResources(checkBoxOverAllWindows, "checkBoxOverAllWindows");
            checkBoxOverAllWindows.Name = "checkBoxOverAllWindows";
            toolTipInfoForConnection.SetToolTip(checkBoxOverAllWindows, resources.GetString("checkBoxOverAllWindows.ToolTip"));
            checkBoxOverAllWindows.UseVisualStyleBackColor = true;
            checkBoxOverAllWindows.CheckedChanged += checkBoxOverAllWindows_CheckedChanged;
            // 
            // labelAnecdotsFromFiles
            // 
            resources.ApplyResources(labelAnecdotsFromFiles, "labelAnecdotsFromFiles");
            labelAnecdotsFromFiles.Name = "labelAnecdotsFromFiles";
            toolTipInfoForConnection.SetToolTip(labelAnecdotsFromFiles, resources.GetString("labelAnecdotsFromFiles.ToolTip"));
            // 
            // labelAnecdotsFromFilesChatCommand
            // 
            resources.ApplyResources(labelAnecdotsFromFilesChatCommand, "labelAnecdotsFromFilesChatCommand");
            labelAnecdotsFromFilesChatCommand.Name = "labelAnecdotsFromFilesChatCommand";
            toolTipInfoForConnection.SetToolTip(labelAnecdotsFromFilesChatCommand, resources.GetString("labelAnecdotsFromFilesChatCommand.ToolTip"));
            // 
            // textBoxAnecdotsFromFilesChatCommand
            // 
            resources.ApplyResources(textBoxAnecdotsFromFilesChatCommand, "textBoxAnecdotsFromFilesChatCommand");
            textBoxAnecdotsFromFilesChatCommand.Name = "textBoxAnecdotsFromFilesChatCommand";
            toolTipInfoForConnection.SetToolTip(textBoxAnecdotsFromFilesChatCommand, resources.GetString("textBoxAnecdotsFromFilesChatCommand.ToolTip"));
            textBoxAnecdotsFromFilesChatCommand.TextChanged += textBoxAnecdotsFromFilesChatCommand_TextChanged;
            // 
            // labelAnecdotsFromFilesChannelPointsCommand
            // 
            resources.ApplyResources(labelAnecdotsFromFilesChannelPointsCommand, "labelAnecdotsFromFilesChannelPointsCommand");
            labelAnecdotsFromFilesChannelPointsCommand.Name = "labelAnecdotsFromFilesChannelPointsCommand";
            toolTipInfoForConnection.SetToolTip(labelAnecdotsFromFilesChannelPointsCommand, resources.GetString("labelAnecdotsFromFilesChannelPointsCommand.ToolTip"));
            // 
            // textBoxAnecdotsFromFilesChannelPoints
            // 
            resources.ApplyResources(textBoxAnecdotsFromFilesChannelPoints, "textBoxAnecdotsFromFilesChannelPoints");
            textBoxAnecdotsFromFilesChannelPoints.Name = "textBoxAnecdotsFromFilesChannelPoints";
            toolTipInfoForConnection.SetToolTip(textBoxAnecdotsFromFilesChannelPoints, resources.GetString("textBoxAnecdotsFromFilesChannelPoints.ToolTip"));
            textBoxAnecdotsFromFilesChannelPoints.TextChanged += textBoxAnecdotsFromFilesChannelPoints_TextChanged;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(linkLabel1, "linkLabel1");
            linkLabel1.Name = "linkLabel1";
            linkLabel1.TabStop = true;
            toolTipInfoForConnection.SetToolTip(linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            // 
            // labelVersionOfProgram
            // 
            resources.ApplyResources(labelVersionOfProgram, "labelVersionOfProgram");
            labelVersionOfProgram.Name = "labelVersionOfProgram";
            toolTipInfoForConnection.SetToolTip(labelVersionOfProgram, resources.GetString("labelVersionOfProgram.ToolTip"));
            // 
            // buttonAnecdotsFromFilesAddFile
            // 
            resources.ApplyResources(buttonAnecdotsFromFilesAddFile, "buttonAnecdotsFromFilesAddFile");
            buttonAnecdotsFromFilesAddFile.Name = "buttonAnecdotsFromFilesAddFile";
            toolTipInfoForConnection.SetToolTip(buttonAnecdotsFromFilesAddFile, resources.GetString("buttonAnecdotsFromFilesAddFile.ToolTip"));
            buttonAnecdotsFromFilesAddFile.UseVisualStyleBackColor = true;
            buttonAnecdotsFromFilesAddFile.Click += buttonAnecdotsFromFilesEnableOrDisableFile_Click;
            // 
            // listBoxAnecdotsFromFilesLoadedFiles
            // 
            resources.ApplyResources(listBoxAnecdotsFromFilesLoadedFiles, "listBoxAnecdotsFromFilesLoadedFiles");
            listBoxAnecdotsFromFilesLoadedFiles.FormattingEnabled = true;
            listBoxAnecdotsFromFilesLoadedFiles.Name = "listBoxAnecdotsFromFilesLoadedFiles";
            toolTipInfoForConnection.SetToolTip(listBoxAnecdotsFromFilesLoadedFiles, resources.GetString("listBoxAnecdotsFromFilesLoadedFiles.ToolTip"));
            // 
            // listBoxAnecdotsFromFilesAllFilesFromFolder
            // 
            resources.ApplyResources(listBoxAnecdotsFromFilesAllFilesFromFolder, "listBoxAnecdotsFromFilesAllFilesFromFolder");
            listBoxAnecdotsFromFilesAllFilesFromFolder.FormattingEnabled = true;
            listBoxAnecdotsFromFilesAllFilesFromFolder.Name = "listBoxAnecdotsFromFilesAllFilesFromFolder";
            toolTipInfoForConnection.SetToolTip(listBoxAnecdotsFromFilesAllFilesFromFolder, resources.GetString("listBoxAnecdotsFromFilesAllFilesFromFolder.ToolTip"));
            // 
            // labelAnecdotsFromFilesAllFilesFromFolder
            // 
            resources.ApplyResources(labelAnecdotsFromFilesAllFilesFromFolder, "labelAnecdotsFromFilesAllFilesFromFolder");
            labelAnecdotsFromFilesAllFilesFromFolder.Name = "labelAnecdotsFromFilesAllFilesFromFolder";
            toolTipInfoForConnection.SetToolTip(labelAnecdotsFromFilesAllFilesFromFolder, resources.GetString("labelAnecdotsFromFilesAllFilesFromFolder.ToolTip"));
            // 
            // labelAnecdotsFromFilesLoadedFiles
            // 
            resources.ApplyResources(labelAnecdotsFromFilesLoadedFiles, "labelAnecdotsFromFilesLoadedFiles");
            labelAnecdotsFromFilesLoadedFiles.Name = "labelAnecdotsFromFilesLoadedFiles";
            toolTipInfoForConnection.SetToolTip(labelAnecdotsFromFilesLoadedFiles, resources.GetString("labelAnecdotsFromFilesLoadedFiles.ToolTip"));
            // 
            // buttonAnecdotsFromFilesDeleteFile
            // 
            resources.ApplyResources(buttonAnecdotsFromFilesDeleteFile, "buttonAnecdotsFromFilesDeleteFile");
            buttonAnecdotsFromFilesDeleteFile.Name = "buttonAnecdotsFromFilesDeleteFile";
            toolTipInfoForConnection.SetToolTip(buttonAnecdotsFromFilesDeleteFile, resources.GetString("buttonAnecdotsFromFilesDeleteFile.ToolTip"));
            buttonAnecdotsFromFilesDeleteFile.UseVisualStyleBackColor = true;
            buttonAnecdotsFromFilesDeleteFile.Click += buttonAnecdotsFromFilesDeleteFile_Click;
            // 
            // linkLabelKnownTroubles
            // 
            resources.ApplyResources(linkLabelKnownTroubles, "linkLabelKnownTroubles");
            linkLabelKnownTroubles.Name = "linkLabelKnownTroubles";
            linkLabelKnownTroubles.TabStop = true;
            toolTipInfoForConnection.SetToolTip(linkLabelKnownTroubles, resources.GetString("linkLabelKnownTroubles.ToolTip"));
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(linkLabelKnownTroubles);
            Controls.Add(buttonAnecdotsFromFilesDeleteFile);
            Controls.Add(labelAnecdotsFromFilesLoadedFiles);
            Controls.Add(labelAnecdotsFromFilesAllFilesFromFolder);
            Controls.Add(listBoxAnecdotsFromFilesAllFilesFromFolder);
            Controls.Add(listBoxAnecdotsFromFilesLoadedFiles);
            Controls.Add(buttonAnecdotsFromFilesAddFile);
            Controls.Add(labelVersionOfProgram);
            Controls.Add(linkLabel1);
            Controls.Add(textBoxAnecdotsFromFilesChannelPoints);
            Controls.Add(labelAnecdotsFromFilesChannelPointsCommand);
            Controls.Add(textBoxAnecdotsFromFilesChatCommand);
            Controls.Add(labelAnecdotsFromFilesChatCommand);
            Controls.Add(labelAnecdotsFromFiles);
            Controls.Add(checkBoxOverAllWindows);
            Controls.Add(labelTwitchClientId);
            Controls.Add(label1);
            Controls.Add(labelAnecdot);
            Controls.Add(textBoxAnecdotChatCommand);
            Controls.Add(labelAnecdotChannelPoints);
            Controls.Add(textBoxAnecdotChannelPoints);
            Controls.Add(labelAnecdotChatCommand);
            Controls.Add(buttonDeleteReplaceAndSubstitude);
            Controls.Add(buttonTtsTextReplace);
            Controls.Add(listBoxTtsSubstitute);
            Controls.Add(listBoxTtsWhatToReplace);
            Controls.Add(textBoxTtsSubstitute);
            Controls.Add(textBoxTtsWhatToReplace);
            Controls.Add(textBoxTwitchClientID);
            Controls.Add(labelHighlightedMessageTts);
            Controls.Add(textBoxHighlightedMessageName);
            Controls.Add(comboBoxTypeOfMessageTts);
            Controls.Add(labelTypeOfMessageTts);
            Controls.Add(buttonTestTtsSkip);
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
        private Button buttonTestTtsSkip;
        private Label labelTypeOfMessageTts;
        private ComboBox comboBoxTypeOfMessageTts;
        private TextBox textBoxHighlightedMessageName;
        private Label labelHighlightedMessageTts;
        private TextBox textBoxTwitchClientID;
        private TextBox textBoxTtsWhatToReplace;
        private TextBox textBoxTtsSubstitute;
        private ListBox listBoxTtsWhatToReplace;
        private ListBox listBoxTtsSubstitute;
        private Button buttonTtsTextReplace;
        private Button buttonDeleteReplaceAndSubstitude;
        private Label labelAnecdotChatCommand;
        private TextBox textBoxAnecdotChannelPoints;
        private Label labelAnecdotChannelPoints;
        private TextBox textBoxAnecdotChatCommand;
        private Label labelAnecdot;
        private Label label1;
        private Label labelTwitchClientId;
        private CheckBox checkBoxOverAllWindows;
        private Label labelAnecdotsFromFiles;
        private Label labelAnecdotsFromFilesChatCommand;
        private TextBox textBoxAnecdotsFromFilesChatCommand;
        private Label labelAnecdotsFromFilesChannelPointsCommand;
        private TextBox textBoxAnecdotsFromFilesChannelPoints;
        private LinkLabel linkLabel1;
        private Label labelVersionOfProgram;
        private Button buttonAnecdotsFromFilesAddFile;
        private ListBox listBoxAnecdotsFromFilesLoadedFiles;
        private ListBox listBoxAnecdotsFromFilesAllFilesFromFolder;
        private Label labelAnecdotsFromFilesAllFilesFromFolder;
        private Label labelAnecdotsFromFilesLoadedFiles;
        private Button buttonAnecdotsFromFilesDeleteFile;
        private LinkLabel linkLabelKnownTroubles;
    }
}