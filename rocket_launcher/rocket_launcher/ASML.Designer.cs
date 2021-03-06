﻿namespace WinForm
{
    partial class Asml
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
            this.left = new System.Windows.Forms.Button();
            this.right = new System.Windows.Forms.Button();
            this.timer_left = new System.Windows.Forms.Timer(this.components);
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.fire = new System.Windows.Forms.Button();
            this.timer_right = new System.Windows.Forms.Timer(this.components);
            this.timer_up = new System.Windows.Forms.Timer(this.components);
            this.timer_down = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.TargetList = new System.Windows.Forms.ListBox();
            this.Version = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.modes = new System.Windows.Forms.ComboBox();
            this.modeLabel = new System.Windows.Forms.Label();
            this.cameraBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phiLabel = new System.Windows.Forms.Label();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.timer_SD = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.startVideo = new System.Windows.Forms.Button();
            this.stopVideo = new System.Windows.Forms.Button();
            this.timer_reset = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(20, 103);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(58, 40);
            this.left.TabIndex = 0;
            this.left.Text = "left";
            this.left.UseVisualStyleBackColor = true;
            this.left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_MouseDown);
            this.left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_MouseUp);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(134, 103);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(62, 40);
            this.right.TabIndex = 1;
            this.right.Text = "right";
            this.right.UseVisualStyleBackColor = true;
            this.right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_MouseDown);
            this.right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // timer_left
            // 
            this.timer_left.Tick += new System.EventHandler(this.timer_left_Tick_1);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(84, 45);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(44, 52);
            this.up.TabIndex = 2;
            this.up.Text = "up";
            this.up.UseVisualStyleBackColor = true;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_MouseUp);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(84, 149);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(44, 53);
            this.down.TabIndex = 3;
            this.down.Text = "down";
            this.down.UseVisualStyleBackColor = true;
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_MouseUp);
            // 
            // fire
            // 
            this.fire.Location = new System.Drawing.Point(84, 103);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(44, 40);
            this.fire.TabIndex = 4;
            this.fire.Text = "Fire";
            this.fire.UseVisualStyleBackColor = true;
            this.fire.Click += new System.EventHandler(this.fire_Click);
            // 
            // timer_right
            // 
            this.timer_right.Tick += new System.EventHandler(this.timer_right_Tick);
            // 
            // timer_up
            // 
            this.timer_up.Tick += new System.EventHandler(this.timer_up_Tick);
            // 
            // timer_down
            // 
            this.timer_down.Tick += new System.EventHandler(this.timer_down_Tick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(13, 15);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(65, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(84, 15);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(57, 23);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // TargetList
            // 
            this.TargetList.FormattingEnabled = true;
            this.TargetList.Location = new System.Drawing.Point(16, 285);
            this.TargetList.Name = "TargetList";
            this.TargetList.Size = new System.Drawing.Size(180, 264);
            this.TargetList.TabIndex = 8;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(808, 9);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(43, 13);
            this.Version.TabIndex = 9;
            this.Version.Text = "v. 0.9.0";
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.Location = new System.Drawing.Point(429, 9);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(73, 13);
            this.GroupName.TabIndex = 10;
            this.GroupName.Text = "ThunderCat";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(147, 15);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(49, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(16, 570);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(95, 23);
            this.openFile.TabIndex = 12;
            this.openFile.Text = "Open Target File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // modes
            // 
            this.modes.FormattingEnabled = true;
            this.modes.Items.AddRange(new object[] {
            "Fire at All",
            "Fire at Foes",
            "Fire at Friends"});
            this.modes.Location = new System.Drawing.Point(57, 231);
            this.modes.Name = "modes";
            this.modes.Size = new System.Drawing.Size(139, 21);
            this.modes.TabIndex = 14;
            this.modes.SelectedIndexChanged += new System.EventHandler(this.modes_SelectedIndexChanged);
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(14, 234);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(37, 13);
            this.modeLabel.TabIndex = 15;
            this.modeLabel.Text = "Mode:";
            // 
            // cameraBox
            // 
            this.cameraBox.Location = new System.Drawing.Point(216, 49);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(635, 500);
            this.cameraBox.TabIndex = 16;
            this.cameraBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Phi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Theta:";
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.Location = new System.Drawing.Point(294, 33);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(0, 13);
            this.phiLabel.TabIndex = 19;
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(382, 33);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(0, 13);
            this.thetaLabel.TabIndex = 20;
            // 
            // timer_SD
            // 
            this.timer_SD.Tick += new System.EventHandler(this.timer_SD_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Time:";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(549, 33);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 22;
            // 
            // startVideo
            // 
            this.startVideo.Location = new System.Drawing.Point(6, 15);
            this.startVideo.Name = "startVideo";
            this.startVideo.Size = new System.Drawing.Size(62, 23);
            this.startVideo.TabIndex = 23;
            this.startVideo.Text = "Start";
            this.startVideo.UseVisualStyleBackColor = true;
            this.startVideo.Click += new System.EventHandler(this.startVideo_Click);
            // 
            // stopVideo
            // 
            this.stopVideo.Location = new System.Drawing.Point(74, 15);
            this.stopVideo.Name = "stopVideo";
            this.stopVideo.Size = new System.Drawing.Size(63, 23);
            this.stopVideo.TabIndex = 24;
            this.stopVideo.Text = "Stop";
            this.stopVideo.UseVisualStyleBackColor = true;
            this.stopVideo.Click += new System.EventHandler(this.stopVideo_Click);
            // 
            // timer_reset
            // 
            this.timer_reset.Tick += new System.EventHandler(this.timer_reset_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.stop);
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Location = new System.Drawing.Point(216, 555);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 44);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search and Destroy";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.startVideo);
            this.groupBox2.Controls.Add(this.stopVideo);
            this.groupBox2.Location = new System.Drawing.Point(706, 555);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 44);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video Feed";
            // 
            // Asml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.thetaLabel);
            this.Controls.Add(this.phiLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cameraBox);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.modes);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.TargetList);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Name = "Asml";
            this.Text = "Asml-ThunderCat";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Timer timer_left;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button fire;
        private System.Windows.Forms.Timer timer_right;
        private System.Windows.Forms.Timer timer_up;
        private System.Windows.Forms.Timer timer_down;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ListBox TargetList;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.ComboBox modes;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.PictureBox cameraBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.Timer timer_SD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button startVideo;
        private System.Windows.Forms.Button stopVideo;
        private System.Windows.Forms.Timer timer_reset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

