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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtlasHome));
            this.stopButton = new System.Windows.Forms.Button();
            this.nowPlayingLabel = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.musicDataGridView = new System.Windows.Forms.DataGridView();
            this.pausePictureBox = new System.Windows.Forms.PictureBox();
            this.stopPictureBox = new System.Windows.Forms.PictureBox();
            this.playPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.musicDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // stopButton
            // 
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(12, 57);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(152, 33);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "STOP";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // nowPlayingLabel
            // 
            this.nowPlayingLabel.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowPlayingLabel.Location = new System.Drawing.Point(12, 9);
            this.nowPlayingLabel.Name = "nowPlayingLabel";
            this.nowPlayingLabel.Size = new System.Drawing.Size(546, 45);
            this.nowPlayingLabel.TabIndex = 3;
            this.nowPlayingLabel.Text = "Now Playing :";
            // 
            // pauseButton
            // 
            this.pauseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pauseButton.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(406, 57);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(152, 33);
            this.pauseButton.TabIndex = 5;
            this.pauseButton.Text = "PAUSE";
            this.pauseButton.UseVisualStyleBackColor = true;
            // 
            // musicDataGridView
            // 
            this.musicDataGridView.AllowUserToAddRows = false;
            this.musicDataGridView.AllowUserToDeleteRows = false;
            this.musicDataGridView.AllowUserToResizeColumns = false;
            this.musicDataGridView.AllowUserToResizeRows = false;
            this.musicDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.musicDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.musicDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.musicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.musicDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.musicDataGridView.Location = new System.Drawing.Point(12, 97);
            this.musicDataGridView.MultiSelect = false;
            this.musicDataGridView.Name = "musicDataGridView";
            this.musicDataGridView.ReadOnly = true;
            this.musicDataGridView.RowHeadersVisible = false;
            this.musicDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.musicDataGridView.Size = new System.Drawing.Size(546, 244);
            this.musicDataGridView.TabIndex = 6;
            this.musicDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.musicDataGridView_CellMouseDoubleClick);
            // 
            // pausePictureBox
            // 
            this.pausePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pausePictureBox.Image")));
            this.pausePictureBox.Location = new System.Drawing.Point(320, 39);
            this.pausePictureBox.Name = "pausePictureBox";
            this.pausePictureBox.Size = new System.Drawing.Size(26, 25);
            this.pausePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pausePictureBox.TabIndex = 7;
            this.pausePictureBox.TabStop = false;
            this.pausePictureBox.Click += new System.EventHandler(this.pausePictureBox_Click);
            // 
            // stopPictureBox
            // 
            this.stopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("stopPictureBox.Image")));
            this.stopPictureBox.Location = new System.Drawing.Point(276, 28);
            this.stopPictureBox.Name = "stopPictureBox";
            this.stopPictureBox.Size = new System.Drawing.Size(42, 53);
            this.stopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.stopPictureBox.TabIndex = 8;
            this.stopPictureBox.TabStop = false;
            this.stopPictureBox.Click += new System.EventHandler(this.stopPictureBox_Click);
            // 
            // playPictureBox
            // 
            this.playPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("playPictureBox.Image")));
            this.playPictureBox.Location = new System.Drawing.Point(245, 33);
            this.playPictureBox.Name = "playPictureBox";
            this.playPictureBox.Size = new System.Drawing.Size(31, 39);
            this.playPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playPictureBox.TabIndex = 9;
            this.playPictureBox.TabStop = false;
            // 
            // AtlasHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 353);
            this.Controls.Add(this.playPictureBox);
            this.Controls.Add(this.stopPictureBox);
            this.Controls.Add(this.pausePictureBox);
            this.Controls.Add(this.musicDataGridView);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.nowPlayingLabel);
            this.Controls.Add(this.stopButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AtlasHome";
            this.Text = "Atlas";
            this.Load += new System.EventHandler(this.AtlasHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label nowPlayingLabel;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.DataGridView musicDataGridView;
        private System.Windows.Forms.PictureBox pausePictureBox;
        private System.Windows.Forms.PictureBox stopPictureBox;
        private System.Windows.Forms.PictureBox playPictureBox;
    }
}

