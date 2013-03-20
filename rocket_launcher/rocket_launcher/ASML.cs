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
using launcher_interface;
using adapter;
using fileReader;
using fileClass;

namespace WinForm
{
    partial class Asml : Form
    {
        IMissileLauncher control;
        int points = 100;
        file Target = null;

        public Asml()
        {
            InitializeComponent();
            control = new LauncherAdapter();          
        }

        //===============================LEFT===============================

        private void left_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void left_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            control.MoveBy(0, -points);
        }

        //===============================RIGHT==============================

        private void right_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();
        }

        private void right_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            control.MoveBy(0, points);
        }

        //===============================UP================================

        private void up_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();
        }

        private void up_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            control.MoveBy(points, 0);
        }

        //===============================DOWN===============================

        private void down_MouseDown(object sender, MouseEventArgs e)
        {
            timer4.Enabled = true;
            timer4.Start();
        }

        private void down_MouseUp(object sender, MouseEventArgs e)
        {
            timer4.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
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
        }

        //===============================STOP===============================

        private void stop_Click(object sender, EventArgs e)
        {           
        }

        private void reset_Click(object sender, EventArgs e)
        {
            control.Reset();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            
            dialog.Filter = "XML Targets |*.xml|INI Targets|*.ini|All Files|*.*";
            DialogResult result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                string path = dialog.FileName;
                Target = FileReader.Instance.addFile(path);
            }

            if (Target != null)
                TargetList.DataSource = Target.list;
        }
    }
}