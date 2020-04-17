namespace GameLauncher
{
    partial class MainView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonPlay = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.currentVersionLabel = new System.Windows.Forms.Label();
            this.downloadStatus = new System.Windows.Forms.Label();
            this.serverIPText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.buttonPullData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonPlay.Location = new System.Drawing.Point(690, 285);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(251, 137);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 373);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(672, 49);
            this.progressBar1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "Choose folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(12, 97);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(672, 226);
            this.LogTextBox.TabIndex = 7;
            this.LogTextBox.Text = "";
            this.LogTextBox.TextChanged += new System.EventHandler(this.LogTextBox_TextChanged);
            // 
            // currentVersionLabel
            // 
            this.currentVersionLabel.AutoSize = true;
            this.currentVersionLabel.Location = new System.Drawing.Point(800, 248);
            this.currentVersionLabel.Name = "currentVersionLabel";
            this.currentVersionLabel.Size = new System.Drawing.Size(27, 20);
            this.currentVersionLabel.TabIndex = 8;
            this.currentVersionLabel.Text = "00";
            // 
            // downloadStatus
            // 
            this.downloadStatus.AutoSize = true;
            this.downloadStatus.Location = new System.Drawing.Point(12, 347);
            this.downloadStatus.Name = "downloadStatus";
            this.downloadStatus.Size = new System.Drawing.Size(131, 20);
            this.downloadStatus.TabIndex = 9;
            this.downloadStatus.Text = "Download Status";
            // 
            // serverIPText
            // 
            this.serverIPText.Location = new System.Drawing.Point(694, 161);
            this.serverIPText.MaxLength = 256;
            this.serverIPText.Name = "serverIPText";
            this.serverIPText.Size = new System.Drawing.Size(247, 26);
            this.serverIPText.TabIndex = 10;
            this.serverIPText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.serverIp_Submit);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(694, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Master server IP";
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(16, 52);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.ReadOnly = true;
            this.FilePathText.Size = new System.Drawing.Size(392, 26);
            this.FilePathText.TabIndex = 12;
            this.FilePathText.Text = "Path";
            // 
            // buttonPullData
            // 
            this.buttonPullData.Location = new System.Drawing.Point(866, 238);
            this.buttonPullData.Name = "buttonPullData";
            this.buttonPullData.Size = new System.Drawing.Size(75, 41);
            this.buttonPullData.TabIndex = 13;
            this.buttonPullData.Text = "refresh";
            this.buttonPullData.UseVisualStyleBackColor = true;
            this.buttonPullData.Click += new System.EventHandler(this.buttonPullData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(733, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "current version";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(953, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPullData);
            this.Controls.Add(this.FilePathText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.serverIPText);
            this.Controls.Add(this.downloadStatus);
            this.Controls.Add(this.currentVersionLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonPlay);
            this.Name = "MainView";
            this.Text = "Game Launcher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Label currentVersionLabel;
        private System.Windows.Forms.Label downloadStatus;
        private System.Windows.Forms.TextBox serverIPText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button buttonPullData;
        private System.Windows.Forms.Label label2;
    }
}

