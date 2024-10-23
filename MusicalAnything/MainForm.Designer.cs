namespace MusicalAnything {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SongList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PauseTimeLbl = new System.Windows.Forms.Label();
            this.EnablePauseCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PauseMaxBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PauseMinBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayMaxBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayMinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ArtistBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AlbumBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.FilenameBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SkipBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.PlayPauseBtn = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.PauseTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SongList, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Player, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1456, 751);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SongList
            // 
            this.SongList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SongList.FormattingEnabled = true;
            this.SongList.ItemHeight = 25;
            this.SongList.Location = new System.Drawing.Point(1047, 54);
            this.SongList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SongList.Name = "SongList";
            this.tableLayoutPanel1.SetRowSpan(this.SongList, 3);
            this.SongList.Size = new System.Drawing.Size(404, 691);
            this.SongList.Sorted = true;
            this.SongList.TabIndex = 4;
            this.SongList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SongList_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.PauseTimeLbl);
            this.panel1.Controls.Add(this.EnablePauseCheck);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.PauseMaxBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PauseMinBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PlayMaxBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PlayMinBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 664);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 87);
            this.panel1.TabIndex = 5;
            // 
            // PauseTimeLbl
            // 
            this.PauseTimeLbl.AutoSize = true;
            this.PauseTimeLbl.Location = new System.Drawing.Point(600, 31);
            this.PauseTimeLbl.Name = "PauseTimeLbl";
            this.PauseTimeLbl.Size = new System.Drawing.Size(103, 26);
            this.PauseTimeLbl.TabIndex = 12;
            this.PauseTimeLbl.Text = "Waiting...";
            // 
            // EnablePauseCheck
            // 
            this.EnablePauseCheck.AutoSize = true;
            this.EnablePauseCheck.Checked = true;
            this.EnablePauseCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EnablePauseCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnablePauseCheck.Location = new System.Drawing.Point(466, 25);
            this.EnablePauseCheck.Margin = new System.Windows.Forms.Padding(4);
            this.EnablePauseCheck.Name = "EnablePauseCheck";
            this.EnablePauseCheck.Size = new System.Drawing.Size(127, 40);
            this.EnablePauseCheck.TabIndex = 11;
            this.EnablePauseCheck.Text = "Enable";
            this.EnablePauseCheck.UseVisualStyleBackColor = true;
            this.EnablePauseCheck.CheckedChanged += new System.EventHandler(this.EnablePauseCheck_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "seconds";
            // 
            // PauseMaxBox
            // 
            this.PauseMaxBox.Location = new System.Drawing.Point(299, 49);
            this.PauseMaxBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PauseMaxBox.Name = "PauseMaxBox";
            this.PauseMaxBox.Size = new System.Drawing.Size(47, 32);
            this.PauseMaxBox.TabIndex = 8;
            this.PauseMaxBox.TextChanged += new System.EventHandler(this.PlayPauseBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "-";
            // 
            // PauseMinBox
            // 
            this.PauseMinBox.Location = new System.Drawing.Point(227, 49);
            this.PauseMinBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PauseMinBox.Name = "PauseMinBox";
            this.PauseMinBox.Size = new System.Drawing.Size(47, 32);
            this.PauseMinBox.TabIndex = 6;
            this.PauseMinBox.TextChanged += new System.EventHandler(this.PlayPauseBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pause duration range";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "seconds";
            // 
            // PlayMaxBox
            // 
            this.PlayMaxBox.Location = new System.Drawing.Point(299, 10);
            this.PlayMaxBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PlayMaxBox.Name = "PlayMaxBox";
            this.PlayMaxBox.Size = new System.Drawing.Size(47, 32);
            this.PlayMaxBox.TabIndex = 3;
            this.PlayMaxBox.TextChanged += new System.EventHandler(this.PlayPauseBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // PlayMinBox
            // 
            this.PlayMinBox.Location = new System.Drawing.Point(227, 10);
            this.PlayMinBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PlayMinBox.Name = "PlayMinBox";
            this.PlayMinBox.Size = new System.Drawing.Size(47, 32);
            this.PlayMinBox.TabIndex = 1;
            this.PlayMinBox.TextChanged += new System.EventHandler(this.PlayPauseBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play duration range";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.SourceBtn);
            this.flowLayoutPanel1.Controls.Add(this.RefreshBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1134, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 48);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // SourceBtn
            // 
            this.SourceBtn.AutoSize = true;
            this.SourceBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SourceBtn.Location = new System.Drawing.Point(5, 6);
            this.SourceBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(158, 36);
            this.SourceBtn.TabIndex = 3;
            this.SourceBtn.Text = "Select Source";
            this.SourceBtn.UseVisualStyleBackColor = true;
            this.SourceBtn.Click += new System.EventHandler(this.SourceBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.RefreshBtn.AutoSize = true;
            this.RefreshBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(172, 12);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(54, 23);
            this.RefreshBtn.TabIndex = 0;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // Player
            // 
            this.Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(4, 233);
            this.Player.Margin = new System.Windows.Forms.Padding(4);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(1034, 427);
            this.Player.TabIndex = 8;
            this.Player.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.Player_MediaChange);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TitleBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.ArtistBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.AlbumBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.FilenameBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1042, 229);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(64, 7);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "Title:";
            // 
            // TitleBox
            // 
            this.TitleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleBox.Location = new System.Drawing.Point(130, 4);
            this.TitleBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.ReadOnly = true;
            this.TitleBox.Size = new System.Drawing.Size(908, 32);
            this.TitleBox.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 47);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Artist:";
            // 
            // ArtistBox
            // 
            this.ArtistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArtistBox.Location = new System.Drawing.Point(130, 44);
            this.ArtistBox.Margin = new System.Windows.Forms.Padding(4);
            this.ArtistBox.Name = "ArtistBox";
            this.ArtistBox.ReadOnly = true;
            this.ArtistBox.Size = new System.Drawing.Size(908, 32);
            this.ArtistBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 26);
            this.label9.TabIndex = 4;
            this.label9.Text = "Album:";
            // 
            // AlbumBox
            // 
            this.AlbumBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlbumBox.Location = new System.Drawing.Point(130, 84);
            this.AlbumBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlbumBox.Name = "AlbumBox";
            this.AlbumBox.ReadOnly = true;
            this.AlbumBox.Size = new System.Drawing.Size(908, 32);
            this.AlbumBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 26);
            this.label10.TabIndex = 6;
            this.label10.Text = "File Name:";
            // 
            // FilenameBox
            // 
            this.FilenameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilenameBox.Location = new System.Drawing.Point(130, 124);
            this.FilenameBox.Margin = new System.Windows.Forms.Padding(4);
            this.FilenameBox.Name = "FilenameBox";
            this.FilenameBox.ReadOnly = true;
            this.FilenameBox.Size = new System.Drawing.Size(908, 32);
            this.FilenameBox.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.SkipBtn);
            this.flowLayoutPanel2.Controls.Add(this.DeleteBtn);
            this.flowLayoutPanel2.Controls.Add(this.PlayPauseBtn);
            this.flowLayoutPanel2.Controls.Add(this.StatusLabel);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(130, 164);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(505, 61);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // SkipBtn
            // 
            this.SkipBtn.AutoSize = true;
            this.SkipBtn.Location = new System.Drawing.Point(4, 4);
            this.SkipBtn.Margin = new System.Windows.Forms.Padding(4);
            this.SkipBtn.Name = "SkipBtn";
            this.SkipBtn.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.SkipBtn.Size = new System.Drawing.Size(100, 50);
            this.SkipBtn.TabIndex = 0;
            this.SkipBtn.Text = "Skip";
            this.SkipBtn.UseVisualStyleBackColor = true;
            this.SkipBtn.Click += new System.EventHandler(this.SkipBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AutoSize = true;
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(112, 4);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DeleteBtn.Size = new System.Drawing.Size(109, 50);
            this.DeleteBtn.TabIndex = 1;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // PlayPauseBtn
            // 
            this.PlayPauseBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.PlayPauseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayPauseBtn.Location = new System.Drawing.Point(229, 4);
            this.PlayPauseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayPauseBtn.Name = "PlayPauseBtn";
            this.PlayPauseBtn.Size = new System.Drawing.Size(159, 53);
            this.PlayPauseBtn.TabIndex = 10;
            this.PlayPauseBtn.Text = "Play";
            this.PlayPauseBtn.UseVisualStyleBackColor = false;
            this.PlayPauseBtn.Click += new System.EventHandler(this.PlayPauseBtn_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(395, 17);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(107, 26);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Loading...";
            // 
            // PauseTimer
            // 
            this.PauseTimer.Interval = 1000;
            this.PauseTimer.Tick += new System.EventHandler(this.PauseTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 751);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Musical Anything";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.ListBox SongList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PauseMaxBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PauseMinBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PlayMaxBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PlayMinBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button PlayPauseBtn;
        private System.Windows.Forms.Timer PauseTimer;
        private System.Windows.Forms.CheckBox EnablePauseCheck;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox FilenameBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox AlbumBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ArtistBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button SkipBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label PauseTimeLbl;
    }
}

