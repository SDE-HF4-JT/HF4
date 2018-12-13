namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.sendNewButton = new System.Windows.Forms.Button();
            this.inboxButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.recipientInput = new System.Windows.Forms.TextBox();
            this.carbonCopyInput = new System.Windows.Forms.TextBox();
            this.titleInput = new System.Windows.Forms.TextBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.messageInput = new System.Windows.Forms.RichTextBox();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.carbonCopyLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.timeToLiveLabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            // recipientInput
            // 
            resources.ApplyResources(this.recipientInput, "recipientInput");
            this.recipientInput.Name = "recipientInput";
            this.recipientInput.TextChanged += new System.EventHandler(this.recipientInput_TextChanged);
            // 
            // carbonCopyInput
            // 
            resources.ApplyResources(this.carbonCopyInput, "carbonCopyInput");
            this.carbonCopyInput.Name = "carbonCopyInput";
            this.carbonCopyInput.TextChanged += new System.EventHandler(this.carbonCopyInput_TextChanged);
            // 
            // titleInput
            // 
            resources.ApplyResources(this.titleInput, "titleInput");
            this.titleInput.Name = "titleInput";
            this.titleInput.TextChanged += new System.EventHandler(this.titleInput_TextChanged);
            // 
            // sendMessageButton
            // 
            resources.ApplyResources(this.sendMessageButton, "sendMessageButton");
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // messageInput
            // 
            resources.ApplyResources(this.messageInput, "messageInput");
            this.messageInput.Name = "messageInput";
            this.messageInput.TextChanged += new System.EventHandler(this.messageInput_TextChanged);
            // 
            // recipientLabel
            // 
            resources.ApplyResources(this.recipientLabel, "recipientLabel");
            this.recipientLabel.Name = "recipientLabel";
            // 
            // carbonCopyLabel
            // 
            resources.ApplyResources(this.carbonCopyLabel, "carbonCopyLabel");
            this.carbonCopyLabel.Name = "carbonCopyLabel";
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            // 
            // timeToLiveLabel
            // 
            resources.ApplyResources(this.timeToLiveLabel, "timeToLiveLabel");
            this.timeToLiveLabel.Name = "timeToLiveLabel";
            // 
            // numericUpDown1
            // 
            resources.ApplyResources(this.numericUpDown1, "numericUpDown1");
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.timeToLiveLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.carbonCopyLabel);
            this.Controls.Add(this.recipientLabel);
            this.Controls.Add(this.messageInput);
            this.Controls.Add(this.sendMessageButton);
            this.Controls.Add(this.titleInput);
            this.Controls.Add(this.carbonCopyInput);
            this.Controls.Add(this.recipientInput);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.inboxButton);
            this.Controls.Add(this.sendNewButton);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendNewButton;
        private System.Windows.Forms.Button inboxButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.TextBox recipientInput;
        private System.Windows.Forms.TextBox carbonCopyInput;
        private System.Windows.Forms.TextBox titleInput;
        private System.Windows.Forms.Button sendMessageButton;
        private System.Windows.Forms.RichTextBox messageInput;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.Label carbonCopyLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label timeToLiveLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}