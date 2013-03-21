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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.fire = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.TargetList = new System.Windows.Forms.ListBox();
            this.Version = new System.Windows.Forms.Label();
            this.GroupName = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(310, 103);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(75, 31);
            this.left.TabIndex = 0;
            this.left.Text = "<<<";
            this.left.UseVisualStyleBackColor = true;
            this.left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.left_MouseDown);
            this.left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.left_MouseUp);
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(450, 103);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(75, 31);
            this.right.TabIndex = 1;
            this.right.Text = ">>>";
            this.right.UseVisualStyleBackColor = true;
            this.right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.right_MouseDown);
            this.right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.right_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(397, 32);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(37, 54);
            this.up.TabIndex = 2;
            this.up.Text = "^\r\n^\r\n^";
            this.up.UseVisualStyleBackColor = true;
            this.up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.up_MouseDown);
            this.up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.up_MouseUp);
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(397, 149);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(37, 57);
            this.down.TabIndex = 3;
            this.down.Text = "V\r\nV\r\nV";
            this.down.UseVisualStyleBackColor = true;
            this.down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.down_MouseDown);
            this.down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.down_MouseUp);
            // 
            // fire
            // 
            this.fire.Location = new System.Drawing.Point(397, 98);
            this.fire.Name = "fire";
            this.fire.Size = new System.Drawing.Size(40, 40);
            this.fire.TabIndex = 4;
            this.fire.Text = "Fire";
            this.fire.UseVisualStyleBackColor = true;
            this.fire.Click += new System.EventHandler(this.fire_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(310, 233);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(397, 233);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 6;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // TargetList
            // 
            this.TargetList.FormattingEnabled = true;
            this.TargetList.Location = new System.Drawing.Point(58, 32);
            this.TargetList.Name = "TargetList";
            this.TargetList.Size = new System.Drawing.Size(164, 212);
            this.TargetList.TabIndex = 8;
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(525, 9);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(43, 13);
            this.Version.TabIndex = 9;
            this.Version.Text = "v. 0.2.5";
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
            this.reset.Location = new System.Drawing.Point(493, 233);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(49, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(97, 263);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(95, 23);
            this.openFile.TabIndex = 12;
            this.openFile.Text = "Open Target File";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // Asml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 298);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button fire;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.ListBox TargetList;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Label GroupName;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button openFile;
    }
}

