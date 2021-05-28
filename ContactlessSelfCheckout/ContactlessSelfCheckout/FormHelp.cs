using System;
using System.Threading;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormHelp : Form
    {
        public FormHelp()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            this.Hide();
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.back_button_hover;
            btnBack.Refresh();
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.back_button;
            btnBack.Refresh();
        }

        private void ImgAssistant_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
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

        
    }
}
