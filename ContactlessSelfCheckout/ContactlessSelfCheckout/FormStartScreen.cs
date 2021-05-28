using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ContactlessSelfCheckout
{
    public partial class FormStartScreen : Form
    {
        public FormStartScreen()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        /// <summary>
        /// This function creates a new object for the FormBasketList, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormBasketList formBasketList = new FormBasketList();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
        }

        private void BtnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.start_button_hover;
            btnStart.Refresh();
        }

        private void BtnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Image = Properties.Resources.start_button;
            btnStart.Refresh();
        }

        /// <summary>
        /// This function creates a new object for the FormOwnBag, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOwnBag_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormOwnBag formOwnBag = new FormOwnBag();
            formOwnBag.Show();
            formOwnBag.Left = this.Left;
            formOwnBag.Top = this.Top;
            this.Hide();
        }

        private void BtnOwnBag_MouseEnter(object sender, EventArgs e)
        {
            btnOwnBag.Image = Properties.Resources.own_bag_button_hover;
            btnOwnBag.Refresh();
        }

        private void BtnOwnBag_MouseLeave(object sender, EventArgs e)
        {
            btnOwnBag.Image = Properties.Resources.own_bag_button;
            btnOwnBag.Refresh();
        }

        /// <summary>
        /// This function creates a new object for the FormHelp, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
        }

        private void BtnHelp_MouseEnter(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.help_button_hover;
            btnHelp.Refresh();
        }

        private void BtnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.help_button;
            btnHelp.Refresh();
        }

        private void FormStartScreen_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormStartScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }

        /// <summary>
        /// This function is called when the mouse is clicked, this function shows a little animation of the hand cursor being grasped by simply changing the image and changing it back
        /// </summary>
        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        /// <summary>
        /// This function is used for closing the kinect sensor mouse control application when the form is closed
        /// </summary>
        /// <param name="name">String variable for identifying the process to be terminated</param>
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

    }
}
