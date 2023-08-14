namespace SimpleTwitchTTS
{
    partial class FormApiGuide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            toolTipExperimentalSettingsForm = new ToolTip(components);
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // toolTipExperimentalSettingsForm
            // 
            toolTipExperimentalSettingsForm.AutomaticDelay = 0;
            toolTipExperimentalSettingsForm.AutoPopDelay = 0;
            toolTipExperimentalSettingsForm.InitialDelay = 500;
            toolTipExperimentalSettingsForm.ReshowDelay = 100;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(89, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(639, 54);
            linkLabel1.TabIndex = 0;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "https://twitchtokengenerator.com/";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(258, 169);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(282, 54);
            linkLabel2.TabIndex = 1;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Youtube guide";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // FormApiGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 232);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Name = "FormApiGuide";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolTip toolTipExperimentalSettingsForm;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}