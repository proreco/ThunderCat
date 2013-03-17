﻿using System;
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
using adapter;
using fileReader;
using fileClass;

namespace WinForm
{
    partial class Asml : Form
    {
        ILauncher control;
        bool on = true;

        public Asml(file target)
        {
            InitializeComponent();
            control = new LauncherAdapter();

            TargetList.DataSource = target.list;
        }

        //===============================LEFT===============================

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            control.command_Left(90);

        }

        //===============================RIGHT===============================

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            timer2.Enabled = true;
            timer2.Start();

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            timer2.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            control.command_Right(90);

        }

        //===============================UP===============================

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            timer3.Enabled = true;
            timer3.Start();

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            timer3.Stop();
        }



        private void timer3_Tick(object sender, EventArgs e)
        {

            control.command_Up(100);

        }

        //===============================DOWN===============================

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            timer4.Enabled = true;
            timer4.Start();

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            timer4.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            control.command_Down(100);

        }

        //===============================FIRE===============================

        private void button5_Click(object sender, EventArgs e)
        {
            control.command_Fire();
        }

        //==============================START===============================

        private void button6_Click(object sender, EventArgs e)
        {
            control.command_switchLED(on);
        }

        //===============================STOP===============================

        private void button7_Click(object sender, EventArgs e)
        {
            timer5.Stop();
            control.command_Stop();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            control.command_reset();
        }

    }
}