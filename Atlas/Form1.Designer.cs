namespace Atlas
{
    partial class AtlasHome
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
            this.musicListBox = new System.Windows.Forms.ListBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.nowPlayingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musicListBox
            // 
            this.musicListBox.FormattingEnabled = true;
            this.musicListBox.Location = new System.Drawing.Point(12, 96);
            this.musicListBox.Name = "musicListBox";
            this.musicListBox.Size = new System.Drawing.Size(337, 251);
            this.musicListBox.TabIndex = 1;
            this.musicListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.musicListBox_MouseDoubleClick);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(12, 67);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(152, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // nowPlayingLabel
            // 
            this.nowPlayingLabel.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingLabel.Location = new System.Drawing.Point(122, 9);
            this.nowPlayingLabel.Name = "nowPlayingLabel";
            this.nowPlayingLabel.Size = new System.Drawing.Size(227, 45);
            this.nowPlayingLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Now Playing:";
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(197, 67);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(152, 23);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // AtlasHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 353);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nowPlayingLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.musicListBox);
            this.Name = "AtlasHome";
            this.Text = "Atlas";
            this.Load += new System.EventHandler(this.AtlasHome_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox musicListBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label nowPlayingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pauseButton;
    }
}

