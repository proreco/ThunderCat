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

namespace WindowsFormsApplication1
{
    class Launcher
    {
        List<string> _items = new List<string>();
        private bool DevicePresent;

        //Bytes used in command
        public byte[] UP;
        public byte[] RIGHT;
        public byte[] LEFT;
        public byte[] DOWN;

        public byte[] FIRE;
        public byte[] STOP;
        public byte[] LED_OFF;
        public byte[] LED_ON;

        private UsbHidPort USB;

        public Launcher()
        {
            //InitializeComponent();

            _items.Add("One");
            //TargetList.DataSource = _items;

            this.UP = new byte[10];
            this.UP[1] = 2;
            this.UP[2] = 2;

            this.DOWN = new byte[10];
            this.DOWN[1] = 2;
            this.DOWN[2] = 1;

            this.LEFT = new byte[10];
            this.LEFT[1] = 2;
            this.LEFT[2] = 4;

            this.RIGHT = new byte[10];
            this.RIGHT[1] = 2;
            this.RIGHT[2] = 8;

            this.FIRE = new byte[10];
            this.FIRE[1] = 2;
            this.FIRE[2] = 0x10;

            this.STOP = new byte[10];
            this.STOP[1] = 2;
            this.STOP[2] = 0x20;

            this.LED_ON = new byte[9];
            this.LED_ON[1] = 3;
            this.LED_ON[2] = 1;

            this.LED_OFF = new byte[9];
            this.LED_OFF[1] = 3;

            this.USB = new UsbHidPort();
            this.USB.ProductId = 0;
            this.USB.SpecifiedDevice = null;
            this.USB.VendorId = 0;
            this.USB.OnSpecifiedDeviceRemoved += new EventHandler(this.USB_OnSpecifiedDeviceRemoved);
            this.USB.OnDataRecieved += new DataRecievedEventHandler(this.USB_OnDataRecieved);
            this.USB.OnSpecifiedDeviceArrived += new EventHandler(this.USB_OnSpecifiedDeviceArrived);

            this.USB.VID_List[0] = 0xa81;
            this.USB.PID_List[0] = 0x701;
            this.USB.VID_List[1] = 0x2123;
            this.USB.PID_List[1] = 0x1010;
            this.USB.ID_List_Cnt = 2;

            IntPtr handle = new IntPtr();
            this.USB.RegisterHandle(handle);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void USB_OnDataRecieved(object sender, DataRecievedEventArgs args)
        {

        }

        private void USB_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {
            this.DevicePresent = true;
            if (this.USB.ProductId == 0x1010)
            {
                this.command_switchLED(true);
            }
        }

        private void USB_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {
            this.DevicePresent = false;
        }

        public void command_switchLED(Boolean turnOn)
        {
            if (DevicePresent)
            {
                if (turnOn)
                {
                    this.SendUSBData(this.LED_ON);
                }
                else
                {
                    this.SendUSBData(this.LED_OFF);
                }
                this.SendUSBData(this.STOP);
            }
        }

        public void SendUSBData(byte[] Data)
        {
            if (this.USB.SpecifiedDevice != null)
            {
                this.USB.SpecifiedDevice.SendData(Data);
            }
        }

        public void moveMissileLauncher(byte[] Data, int interval)
        {
            if (DevicePresent)
            {
                this.command_switchLED(true);
                SendUSBData(Data);
                Thread.Sleep(interval);
                this.SendUSBData(this.STOP);

            }
        }
    }
}
