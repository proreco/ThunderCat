using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UsbLibrary;
using Microsoft.Win32;
using System.IO;
using System.Media;
using System.Diagnostics;
using System.Threading;
using launcherInterface;
using adapter;
using fileReader;
using filesRead;

namespace WinForm
{
    partial class Asml : Form
    {
        IMissileLauncher control;
        int points = 100;   // amount to move by
        file Target = null;

        public Asml()
        {
            InitializeComponent();
            control = new LauncherAdapter();          
        }      

        //===============================LEFT===============================
        private void left_MouseDown(object sender, MouseEventArgs e)
        {
            timer_left.Enabled = true;
            timer_left.Start();
        }

        private void left_MouseUp(object sender, MouseEventArgs e)
        {
            timer_left.Stop();
        }

        private void timer_left_Tick_1(object sender, EventArgs e)
        {
            control.MoveBy(0, -points);
        }

        //===============================RIGHT==============================
        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            timer_right.Enabled = true;
            timer_right.Start();
        }

        private void right_MouseUp(object sender, MouseEventArgs e)
        {
            timer_right.Stop();
        }

        private void timer_right_Tick(object sender, EventArgs e)
        {
            control.MoveBy(0, points);
        }

        //===============================UP================================
        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            timer_up.Enabled = true;
            timer_up.Start();
        }

        private void up_MouseUp(object sender, MouseEventArgs e)
        {
            timer_up.Stop();
        }

        private void timer_up_Tick(object sender, EventArgs e)
        {
            control.MoveBy(points, 0);
        }

        //===============================DOWN===============================
        private void down_MouseDown(object sender, MouseEventArgs e)
        {
            timer_down.Enabled = true;
            timer_down.Start();
        }

        private void down_MouseUp(object sender, MouseEventArgs e)
        {
            timer_down.Stop();
        }

        private void timer_down_Tick(object sender, EventArgs e)
        {
            control.MoveBy(-points, 0);
        }

        //===============================FIRE===============================
        private void fire_Click(object sender, EventArgs e)
        {
            control.Fire();
        }

        //==============================START===============================
        private void start_Click(object sender, EventArgs e)
        {
            // to be implemented
        }

        //===============================STOP===============================
        private void stop_Click(object sender, EventArgs e)
        {
            // to be implemented
        }

        //===============================RESET===============================
        private void reset_Click(object sender, EventArgs e)
        {
            control.Reset();
        }

        //==============================Open File============================
        // opens file, sends it to file reader and returns with targets
        // that get displayed in the TargetList list box
        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.Filter = "XML Targets |*.xml|INI Targets|*.ini|All Files|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.FileName;

                FileReader instance = FileReader.GetInstance();
                Target = instance.addFile(path);
                
            }

            if (Target != null)
                TargetList.DataSource = Target.list;
        }
    }
}