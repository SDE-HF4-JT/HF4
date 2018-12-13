namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.sendNewButton = new System.Windows.Forms.Button();
            this.inboxButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.deleteMessageButton = new System.Windows.Forms.Button();
            this.InboxList = new System.Windows.Forms.ListBox();
            this.InboxLabel = new System.Windows.Forms.Label();
            this.MessageTextbox = new System.Windows.Forms.RichTextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.accountNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sendNewButton
            // 
            resources.ApplyResources(this.sendNewButton, "sendNewButton");
            this.sendNewButton.Name = "sendNewButton";
            this.sendNewButton.UseVisualStyleBackColor = true;
            this.sendNewButton.Click += new System.EventHandler(this.sendNewButton_Click);
            // 
            // inboxButton
            // 
            resources.ApplyResources(this.inboxButton, "inboxButton");
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.UseVisualStyleBackColor = true;
            this.inboxButton.Click += new System.EventHandler(this.inboxButton_Click);
            // 
            // logOutButton
            // 
            resources.ApplyResources(this.logOutButton, "logOutButton");
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // deleteMessageButton
            // 
            resources.ApplyResources(this.deleteMessageButton, "deleteMessageButton");
            this.deleteMessageButton.Name = "deleteMessageButton";
            this.deleteMessageButton.UseVisualStyleBackColor = true;
            this.deleteMessageButton.Click += new System.EventHandler(this.deleteMessageButton_Click);
            // 
            // InboxList
            // 
            this.InboxList.FormattingEnabled = true;
            resources.ApplyResources(this.InboxList, "InboxList");
            this.InboxList.Name = "InboxList";
            this.InboxList.SelectedIndexChanged += new System.EventHandler(this.InboxList_SelectedIndexChanged);
            // 
            // InboxLabel
            // 
            resources.ApplyResources(this.InboxLabel, "InboxLabel");
            this.InboxLabel.Name = "InboxLabel";
            this.InboxLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MessageTextbox
            // 
            resources.ApplyResources(this.MessageTextbox, "MessageTextbox");
            this.MessageTextbox.Name = "MessageTextbox";
            this.MessageTextbox.ReadOnly = true;
            this.MessageTextbox.TextChanged += new System.EventHandler(this.MessageTextbox_TextChanged);
            // 
            // messageLabel
            // 
            resources.ApplyResources(this.messageLabel, "messageLabel");
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // accountNameLabel
            // 
            resources.ApplyResources(this.accountNameLabel, "accountNameLabel");
            this.accountNameLabel.Name = "accountNameLabel";
            this.accountNameLabel.Click += new System.EventHandler(this.accountNameLabel_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.accountNameLabel);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.MessageTextbox);
            this.Controls.Add(this.InboxLabel);
            this.Controls.Add(this.InboxList);
            this.Controls.Add(this.deleteMessageButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.inboxButton);
            this.Controls.Add(this.sendNewButton);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendNewButton;
        private System.Windows.Forms.Button inboxButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button deleteMessageButton;
        private System.Windows.Forms.ListBox InboxList;
        private System.Windows.Forms.Label InboxLabel;
        private System.Windows.Forms.RichTextBox MessageTextbox;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label accountNameLabel;
    }
}