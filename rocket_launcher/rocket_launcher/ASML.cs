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
using Emgu.CV;
using Emgu.CV.Structure;

namespace WinForm
{
    partial class Asml : Form
    {
        IMissileLauncher control;
        Capture camera;
        TargetManager target;
        Thread threadD;
        Controller mediator;
        bool isProcessing;
        Stopwatch stopwatch;

        int degree = 4;   // amount to move by
        int mode;
        ModeType Mode;

        public Asml()
        {
            InitializeComponent();

            control = new LauncherAdapter();
            target = new TargetManager();
            mediator = new Controller();
            camera = new Capture();
            stopwatch = new Stopwatch();
            isProcessing = false;
            
            target.AddedTarget +=manager_AddedTarget;
        }

        private void manager_AddedTarget(object sender, reader target)
        {
            TargetList.DataSource = target.list;
            
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
            control.MoveBy(0, -degree);
            thetaLabel.Text = control.Theta.ToString();
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
            control.MoveBy(0, degree);
            thetaLabel.Text = control.Theta.ToString();
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
            control.MoveBy(degree, 0);
            phiLabel.Text = control.Phi.ToString();
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
            control.MoveBy(-degree, 0);
            phiLabel.Text = control.Phi.ToString();
        }

        //===============================FIRE===============================
        private void fire_Click(object sender, EventArgs e)
        {
            control.Fire();
        }

        //==============================START===============================
        private void start_Click(object sender, EventArgs e)
        {
            //thread.Start();


            mediator.Start();
                phiLabel.Text = Convert.ToString(target.X);
                timer_SD.Enabled = true;

                threadD = new Thread(() => mediator.destroy(target, control, Mode));
                threadD.Start();

                
                //Thread.Sleep(100);

            
            stopwatch.Restart();
        }
        //===============================STOP===============================
        private void stop_Click(object sender, EventArgs e)
        {
            //thread.Stop();
            mediator.Stop();
            //stopped = true;
            stopwatch.Stop();
        }

        private void timer_SD_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = stopwatch.Elapsed;
            timeLabel.Text = timeSpan.ToString("mm\\:ss") ;
        }

        //===============================RESET===============================
        private void reset_Click(object sender, EventArgs e)
        {
            control.Reset();
            phiLabel.Text = control.Phi.ToString();
            thetaLabel.Text = control.Theta.ToString();
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
            imageTimer.Enabled = (imageTimer.Enabled == false);
            isProcessing = false;
        }

        private void stopVideo_Click(object sender, EventArgs e)
        {
            imageTimer.Enabled = !(imageTimer.Enabled == true);
        }

        private void GetImage()
        {
            Image<Bgr, byte> image = camera.QueryFrame();
            Image windowsFormImage = image.ToBitmap();
            cameraBox.Image = windowsFormImage;
        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            GetImage();
            if (isProcessing)
            {
                // simulate a lot of processing
                Thread.Sleep(3000);
            }

        }

    }
}