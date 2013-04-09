namespace WinForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.modes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(205, 125);
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
            this.right.Location = new System.Drawing.Point(319, 125);
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
            this.up.Location = new System.Drawing.Point(269, 67);
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
            this.down.Location = new System.Drawing.Point(269, 171);
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
            this.fire.Location = new System.Drawing.Point(269, 125);
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
            this.start.Location = new System.Drawing.Point(198, 259);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(65, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(269, 259);
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
            this.TargetList.Location = new System.Drawing.Point(28, 32);
            this.TargetList.Name = "TargetList";
            this.TargetList.Size = new System.Drawing.Size(164, 212);
            this.TargetList.TabIndex = 8;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(570, 9);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(43, 13);
            this.Version.TabIndex = 9;
            this.Version.Text = "v. 0.3.1";
            // 
            // GroupName
            // 
            this.GroupName.AutoSize = true;
            this.GroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupName.Location = new System.Drawing.Point(263, 9);
            this.GroupName.Name = "GroupName";
            this.GroupName.Size = new System.Drawing.Size(73, 13);
            this.GroupName.TabIndex = 10;
            this.GroupName.Text = "ThunderCat";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(332, 259);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(49, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(28, 259);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(95, 23);
            this.openFile.TabIndex = 12;
            this.openFile.Text = "Open Target File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(416, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 201);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // modes
            // 
            this.modes.FormattingEnabled = true;
            this.modes.Items.AddRange(new object[] {
            "Fire All",
            "Fire Foes",
            "Fire Friends"});
            this.modes.Location = new System.Drawing.Point(416, 261);
            this.modes.Name = "modes";
            this.modes.Size = new System.Drawing.Size(110, 21);
            this.modes.TabIndex = 14;
            this.modes.SelectedIndexChanged += new System.EventHandler(this.modes_SelectedIndexChanged);
            // 
            // Asml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 313);
            this.Controls.Add(this.modes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.GroupName);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.TargetList);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.fire);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Name = "Asml";
            this.Text = "Asml-ThunderCat";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox modes;
    }
}

