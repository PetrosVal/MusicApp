namespace Music_Player
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Play_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.Prev_button = new System.Windows.Forms.Button();
            this.Songs = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trackVol = new System.Windows.Forms.TrackBar();
            this.Vol = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Button();
            this.Random = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nowPlaying = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Display = new System.Windows.Forms.TrackBar();
            this.Favorites = new System.Windows.Forms.ListBox();
            this.gif = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Editbutton = new System.Windows.Forms.PictureBox();
            this.Deletebutton = new System.Windows.Forms.PictureBox();
            this.Addbutton = new System.Windows.Forms.PictureBox();
            this.songDuration = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.trackFav = new System.Windows.Forms.Timer(this.components);
            this.displayTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVol)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deletebutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addbutton)).BeginInit();
            this.SuspendLayout();
            // 
            // Play_button
            // 
            this.Play_button.BackgroundImage = global::Music_Player.Properties.Resources.buttonBackground;
            this.Play_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Play_button.Location = new System.Drawing.Point(353, 14);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(146, 60);
            this.Play_button.TabIndex = 0;
            this.Play_button.Text = "Play";
            this.Play_button.UseVisualStyleBackColor = true;
            this.Play_button.Click += new System.EventHandler(this.Play_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.BackgroundImage = global::Music_Player.Properties.Resources.buttonBackground;
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Next_button.Location = new System.Drawing.Point(709, 44);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 30);
            this.Next_button.TabIndex = 2;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Prev_button
            // 
            this.Prev_button.BackgroundImage = global::Music_Player.Properties.Resources.buttonBackground;
            this.Prev_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prev_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prev_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Prev_button.Location = new System.Drawing.Point(235, 43);
            this.Prev_button.Name = "Prev_button";
            this.Prev_button.Size = new System.Drawing.Size(75, 31);
            this.Prev_button.TabIndex = 3;
            this.Prev_button.Text = "Prev";
            this.Prev_button.UseVisualStyleBackColor = true;
            this.Prev_button.Click += new System.EventHandler(this.Prev_button_Click);
            // 
            // Songs
            // 
            this.Songs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(57)))));
            this.Songs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Songs.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Songs.FormattingEnabled = true;
            this.Songs.ItemHeight = 18;
            this.Songs.Location = new System.Drawing.Point(829, 57);
            this.Songs.Name = "Songs";
            this.Songs.Size = new System.Drawing.Size(252, 400);
            this.Songs.TabIndex = 4;
            this.Songs.SelectedIndexChanged += new System.EventHandler(this.Songs_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.aboutToolStripMenuItem2,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1093, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem1,
            this.playToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // addSongsToolStripMenuItem
            // 
            this.addSongsToolStripMenuItem.Name = "addSongsToolStripMenuItem";
            this.addSongsToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.addSongsToolStripMenuItem.Text = "Add songs";
            this.addSongsToolStripMenuItem.Click += new System.EventHandler(this.addSongsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.editToolStripMenuItem.Text = "Edit song";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.deleteToolStripMenuItem1.Text = "Delete song";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.playToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // trackVol
            // 
            this.trackVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(57)))));
            this.trackVol.LargeChange = 0;
            this.trackVol.Location = new System.Drawing.Point(814, 21);
            this.trackVol.Maximum = 100;
            this.trackVol.Name = "trackVol";
            this.trackVol.Size = new System.Drawing.Size(249, 56);
            this.trackVol.TabIndex = 7;
            this.trackVol.Value = 50;
            this.trackVol.Scroll += new System.EventHandler(this.trackVol_Scroll_);
            // 
            // Vol
            // 
            this.Vol.AutoSize = true;
            this.Vol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vol.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Vol.Location = new System.Drawing.Point(903, 0);
            this.Vol.Name = "Vol";
            this.Vol.Size = new System.Drawing.Size(64, 18);
            this.Vol.TabIndex = 8;
            this.Vol.Text = "Volume";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Random);
            this.panel1.Controls.Add(this.Prev_button);
            this.panel1.Controls.Add(this.Play_button);
            this.panel1.Controls.Add(this.Next_button);
            this.panel1.Controls.Add(this.trackVol);
            this.panel1.Controls.Add(this.Vol);
            this.panel1.Location = new System.Drawing.Point(15, 543);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 85);
            this.panel1.TabIndex = 9;
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::Music_Player.Properties.Resources.buttonBackground;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Stop.Location = new System.Drawing.Point(527, 14);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(146, 60);
            this.Stop.TabIndex = 24;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Random
            // 
            this.Random.Image = global::Music_Player.Properties.Resources.couple35;
            this.Random.Location = new System.Drawing.Point(38, 21);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(64, 53);
            this.Random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Random.TabIndex = 23;
            this.Random.TabStop = false;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(18, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Producer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(21, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Release Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(21, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(18, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Language:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Now Playing:";
            // 
            // nowPlaying
            // 
            this.nowPlaying.AutoSize = true;
            this.nowPlaying.BackColor = System.Drawing.Color.Transparent;
            this.nowPlaying.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.nowPlaying.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nowPlaying.Location = new System.Drawing.Point(156, 516);
            this.nowPlaying.Name = "nowPlaying";
            this.nowPlaying.Size = new System.Drawing.Size(13, 18);
            this.nowPlaying.TabIndex = 17;
            this.nowPlaying.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(168, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = " ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(101, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(126, 447);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(126, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(318, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "Favorites:";
            // 
            // Display
            // 
            this.Display.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(57)))));
            this.Display.Enabled = false;
            this.Display.LargeChange = 0;
            this.Display.Location = new System.Drawing.Point(322, 268);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(477, 56);
            this.Display.SmallChange = 0;
            this.Display.TabIndex = 25;
            this.Display.TabStop = false;
            this.Display.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // Favorites
            // 
            this.Favorites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(8)))), ((int)(((byte)(57)))));
            this.Favorites.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.Favorites.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Favorites.FormattingEnabled = true;
            this.Favorites.ItemHeight = 18;
            this.Favorites.Location = new System.Drawing.Point(322, 60);
            this.Favorites.Name = "Favorites";
            this.Favorites.Size = new System.Drawing.Size(477, 202);
            this.Favorites.TabIndex = 26;
            this.Favorites.SelectedIndexChanged += new System.EventHandler(this.Favorites_SelectedIndexChanged);
            // 
            // gif
            // 
            this.gif.BackColor = System.Drawing.Color.Transparent;
            this.gif.Image = global::Music_Player.Properties.Resources.musicplayer;
            this.gif.Location = new System.Drawing.Point(322, 330);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(477, 184);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gif.TabIndex = 16;
            this.gif.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Music_Player.Properties.Resources.icon;
            this.pictureBox1.Location = new System.Drawing.Point(25, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Editbutton
            // 
            this.Editbutton.BackColor = System.Drawing.Color.Transparent;
            this.Editbutton.Image = global::Music_Player.Properties.Resources.editbutton;
            this.Editbutton.Location = new System.Drawing.Point(921, 463);
            this.Editbutton.Name = "Editbutton";
            this.Editbutton.Size = new System.Drawing.Size(77, 74);
            this.Editbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Editbutton.TabIndex = 28;
            this.Editbutton.TabStop = false;
            this.Editbutton.Click += new System.EventHandler(this.Editbutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.Color.Transparent;
            this.Deletebutton.Image = global::Music_Player.Properties.Resources.deletebutton;
            this.Deletebutton.Location = new System.Drawing.Point(1004, 463);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(77, 74);
            this.Deletebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Deletebutton.TabIndex = 29;
            this.Deletebutton.TabStop = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Transparent;
            this.Addbutton.Image = global::Music_Player.Properties.Resources.Addsongs;
            this.Addbutton.Location = new System.Drawing.Point(829, 463);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(77, 74);
            this.Addbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Addbutton.TabIndex = 30;
            this.Addbutton.TabStop = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // songDuration
            // 
            this.songDuration.Interval = 1000;
            this.songDuration.Tick += new System.EventHandler(this.songDuration_Tick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(825, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Songs:";
            // 
            // trackFav
            // 
            this.trackFav.Interval = 3000;
            this.trackFav.Tick += new System.EventHandler(this.trackFav_Tick);
            // 
            // displayTimer
            // 
            this.displayTimer.Tick += new System.EventHandler(this.displayTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::Music_Player.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1093, 640);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Editbutton);
            this.Controls.Add(this.Favorites);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nowPlaying);
            this.Controls.Add(this.gif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Songs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Music Player";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackVol)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Editbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deletebutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Addbutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Prev_button;
        private System.Windows.Forms.ListBox Songs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TrackBar trackVol;
        private System.Windows.Forms.Label Vol;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.PictureBox Random;
        private System.Windows.Forms.Label nowPlaying;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.TrackBar Display;
        private System.Windows.Forms.ListBox Favorites;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Editbutton;
        private System.Windows.Forms.PictureBox Deletebutton;
        private System.Windows.Forms.PictureBox Addbutton;
        private System.Windows.Forms.Timer songDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem playToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Timer trackFav;
        private System.Windows.Forms.Timer displayTimer;
    }
}

