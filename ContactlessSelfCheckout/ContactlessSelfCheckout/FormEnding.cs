using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormEnding : Form
    {

        public FormEnding()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            InitializeComponent();
        }

        private void ImgOrangeCircle_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
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

        private void FormEnding_Shown(object sender, EventArgs e)
        {
            //Thread.Sleep(5000);
            //Application.Restart();
        }

        private void FormEnding_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormEnding_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
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

        
    }
}
