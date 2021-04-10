namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.OpenFile = new System.Windows.Forms.Button();
            this.PlayFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Playbtn = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(270, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(600, 544);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(53, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(102, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 382);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // OpenFile
            // 
            this.OpenFile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OpenFile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.OpenFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OpenFile.Location = new System.Drawing.Point(281, 50);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(294, 32);
            this.OpenFile.TabIndex = 11;
            this.OpenFile.Text = "Open Specific Files";
            this.OpenFile.UseVisualStyleBackColor = false;
            this.OpenFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // PlayFile
            // 
            this.PlayFile.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PlayFile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.PlayFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PlayFile.Location = new System.Drawing.Point(69, 423);
            this.PlayFile.Name = "PlayFile";
            this.PlayFile.Size = new System.Drawing.Size(142, 22);
            this.PlayFile.TabIndex = 13;
            this.PlayFile.Text = "Turn On Radio (Plays instantly)";
            this.PlayFile.UseVisualStyleBackColor = false;
            this.PlayFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(581, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(269, 147);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(-8, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(283, 530);
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // Playbtn
            // 
            this.Playbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Playbtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Playbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Playbtn.Location = new System.Drawing.Point(281, 88);
            this.Playbtn.Name = "Playbtn";
            this.Playbtn.Size = new System.Drawing.Size(119, 32);
            this.Playbtn.TabIndex = 16;
            this.Playbtn.Text = "Play";
            this.Playbtn.UseVisualStyleBackColor = false;
            this.Playbtn.Click += new System.EventHandler(this.Playbtn_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Next.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Next.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Next.Location = new System.Drawing.Point(281, 126);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(119, 32);
            this.Next.TabIndex = 18;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Previous
            // 
            this.Previous.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Previous.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Previous.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Previous.Location = new System.Drawing.Point(406, 126);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(119, 32);
            this.Previous.TabIndex = 19;
            this.Previous.Text = "Previous";
            this.Previous.UseVisualStyleBackColor = false;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Remove.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.Remove.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Remove.Location = new System.Drawing.Point(406, 88);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(119, 32);
            this.Remove.TabIndex = 20;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(281, 168);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(569, 353);
            this.Player.TabIndex = 1;
            this.Player.Enter += new System.EventHandler(this.Player_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(862, 533);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Playbtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.PlayFile);
            this.Controls.Add(this.OpenFile);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button OpenFile;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button PlayFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button Playbtn;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Remove;
    }
}

