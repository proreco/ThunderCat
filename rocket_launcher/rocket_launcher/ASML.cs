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
using ASMLEngineSdk;
using adapter;
using fileReader;
using filesRead;
using targetManager;
using modeType;
using controller;
using threads;
using Emgu.CV;
using Emgu.CV.Structure;

namespace WinForm
{
    partial class Asml : Form
    {
        IMissileLauncher launcher;
        Capture camera;
        TargetManager target;
        Thread thread;
        Controller control;
        Stopwatch stopwatch;
        Threads threadCamera;

        int degree = 4;   // amount to move by
        int mode;
        ModeType Mode;

        public Asml()
        {
            InitializeComponent();

            launcher = new LauncherAdapter();
            threadCamera = new Threads();
            target = new TargetManager();
            control = new Controller();
            camera = new Capture();
            stopwatch = new Stopwatch();
            
            target.AddedTarget +=manager_AddedTarget;
            threadCamera.DataCaptured += new EventHandler<CEventArgs>(thread_DataCaptured);
        }
        private void manager_AddedTarget(object sender, reader target)
        {
            TargetList.DataSource = target.list;            
        }
        void thread_DataCaptured(object sender, CEventArgs e)
        {
                DataHandler(sender, e);
        }
        private void DataHandler(object sender, CEventArgs e)
        {
            cameraBox.Image = e.LastData.ToBitmap();
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
            launcher.MoveBy(0, -degree);
            thetaLabel.Text = launcher.Theta.ToString();
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
            launcher.MoveBy(0, degree);
            thetaLabel.Text = launcher.Theta.ToString();
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
            launcher.MoveBy(degree, 0);
            phiLabel.Text = launcher.Phi.ToString();
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
            launcher.MoveBy(-degree, 0);
            phiLabel.Text = launcher.Phi.ToString();
        }
        //===============================FIRE===============================
        private void fire_Click(object sender, EventArgs e)
        {
            launcher.Fire();
        }
        //==============================START===============================
        private void start_Click(object sender, EventArgs e)
        {

            control.Start();

            timer_SD.Enabled = true;

            thread = new Thread(() => control.Destroy(target, launcher, Mode));

            thread.Start();

            stopwatch.Restart();
        }
        //===============================STOP===============================
        private void stop_Click(object sender, EventArgs e)
        {
            control.Stop();

            stopwatch.Stop();
        }
        private void timer_SD_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = stopwatch.Elapsed;
            timeLabel.Text = timeSpan.ToString("mm\\:ss") ;
            phiLabel.Text = launcher.Phi.ToString();
            thetaLabel.Text = launcher.Theta.ToString();
        }
        //===============================RESET===============================
        private void reset_Click(object sender, EventArgs e)
        {
            
            thread = new Thread(() => control.Reset(launcher));
            thread.Start();
            phiLabel.Text = launcher.Phi.ToString();
            thetaLabel.Text = launcher.Theta.ToString();
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
                target.addTarget(instance.readFile(path));
            }
        }
        private void modes_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = modes.SelectedIndex;
            if (mode == (int)ModeType.fireAll)
                Mode = ModeType.fireAll;
            else if (mode == (int)ModeType.fireFoes)
                Mode = ModeType.fireFoes;
            else
                Mode = ModeType.fireFriends;
        }
        private void startVideo_Click(object sender, EventArgs e)
        {
            threadCamera.Start();
        }
        private void stopVideo_Click(object sender, EventArgs e)
        {
            threadCamera.Stop();
        }
    }
}