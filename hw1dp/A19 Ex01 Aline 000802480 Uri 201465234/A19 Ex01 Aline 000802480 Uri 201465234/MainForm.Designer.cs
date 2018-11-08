namespace A19_Ex01_Aline_000802480_Uri_201465234
{
    partial class MainForm
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MostLikedPics = new System.Windows.Forms.ListBox();
            this.FriendsNextToYou = new System.Windows.Forms.ListBox();
            this.EventsNexToYou = new System.Windows.Forms.ListBox();
            this.FriendsList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(643, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 19);
            this.button1.TabIndex = 2;
            this.button1.Text = "Post";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 148);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Remember Me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 93);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // MostLikedPics
            // 
            this.MostLikedPics.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MostLikedPics.FormattingEnabled = true;
            this.MostLikedPics.HorizontalScrollbar = true;
            this.MostLikedPics.Location = new System.Drawing.Point(269, 73);
            this.MostLikedPics.Name = "MostLikedPics";
            this.MostLikedPics.Size = new System.Drawing.Size(328, 342);
            this.MostLikedPics.TabIndex = 6;
            // 
            // FriendsNextToYou
            // 
            this.FriendsNextToYou.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FriendsNextToYou.FormattingEnabled = true;
            this.FriendsNextToYou.HorizontalScrollbar = true;
            this.FriendsNextToYou.Location = new System.Drawing.Point(269, 439);
            this.FriendsNextToYou.Name = "FriendsNextToYou";
            this.FriendsNextToYou.Size = new System.Drawing.Size(671, 82);
            this.FriendsNextToYou.TabIndex = 7;
            // 
            // EventsNexToYou
            // 
            this.EventsNexToYou.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EventsNexToYou.FormattingEnabled = true;
            this.EventsNexToYou.HorizontalScrollbar = true;
            this.EventsNexToYou.Location = new System.Drawing.Point(612, 73);
            this.EventsNexToYou.Name = "EventsNexToYou";
            this.EventsNexToYou.Size = new System.Drawing.Size(328, 342);
            this.EventsNexToYou.TabIndex = 8;
            // 
            // FriendsList
            // 
            this.FriendsList.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FriendsList.FormattingEnabled = true;
            this.FriendsList.HorizontalScrollbar = true;
            this.FriendsList.Location = new System.Drawing.Point(25, 199);
            this.FriendsList.Name = "FriendsList";
            this.FriendsList.Size = new System.Drawing.Size(218, 316);
            this.FriendsList.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(973, 533);
            this.Controls.Add(this.FriendsList);
            this.Controls.Add(this.EventsNexToYou);
            this.Controls.Add(this.FriendsNextToYou);
            this.Controls.Add(this.MostLikedPics);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "MainForm";
            this.Text = "Desktop Facebook App";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox MostLikedPics;
        private System.Windows.Forms.ListBox FriendsNextToYou;
        private System.Windows.Forms.ListBox EventsNexToYou;
        private System.Windows.Forms.ListBox FriendsList;
    }
}

