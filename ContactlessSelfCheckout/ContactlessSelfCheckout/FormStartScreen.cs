﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace ContactlessSelfCheckout
{
    public partial class FormStartScreen : Form
    {
        public string formTitle = "Start";
        public FormStartScreen()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");

            if (!IsProcessOpen("KinectV2MouseControl"))
            {
                Process kinectMouseControls = new Process();
                kinectMouseControls.StartInfo.FileName = @"G:\VisualStudioRepos\kinectv2mousecontrol\src\KinectV2MouseControl\bin\Debug\KinectV2MouseControl.exe";
                kinectMouseControls.Start();
            }
            
        }

        private bool IsProcessOpen(string name)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void CloseProcess(string name)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(name))
                {
                    process.Kill();
                }
            }
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormBasketList, hides the current form, and shows the new form
            FormBasketList formBasketList = new FormBasketList();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
        }

        private void OwnBagButton_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormOwnBag, hides the current form, and shows the new form
            FormOwnBag formOwnBag= new FormOwnBag();
            formOwnBag.Show();
            formOwnBag.Left = this.Left;
            formOwnBag.Top = this.Top;
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
        }

        private void FormStartScreen_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormStartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }
    }
}
