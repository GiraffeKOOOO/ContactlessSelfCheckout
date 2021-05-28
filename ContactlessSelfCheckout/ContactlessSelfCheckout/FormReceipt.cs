using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormReceipt : Form
    {
        public FormReceipt()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            InitializeComponent();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            this.Hide();
            FormEnding formEnding = new FormEnding();
            formEnding.Show();
            formEnding.Left = this.Left;
            formEnding.Top = this.Top;
        }

        private void BtnNo_MouseEnter(object sender, EventArgs e)
        {
            btnNo.Image = Properties.Resources.no_button_hover;
            btnNo.Refresh();
        }

        private void BtnNo_MouseLeave(object sender, EventArgs e)
        {
            btnNo.Image = Properties.Resources.no_button;
            btnNo.Refresh();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            this.Hide();
            FormEnding formEnding = new FormEnding();
            formEnding.Show();
            formEnding.Left = this.Left;
            formEnding.Top = this.Top;
        }

        private void BtnYes_MouseEnter(object sender, EventArgs e)
        {
            btnYes.Image = Properties.Resources.yes_button_hover;
            btnYes.Refresh();
        }

        private void BtnYes_MouseLeave(object sender, EventArgs e)
        {
            btnYes.Image = Properties.Resources.yes_button;
            btnYes.Refresh();
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

        private void FormReceipt_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormReceipt_FormClosed(object sender, FormClosedEventArgs e)
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
