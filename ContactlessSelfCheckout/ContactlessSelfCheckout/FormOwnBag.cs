using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormOwnBag : Form
    {
        public string formTitle = "OwnBag";
        public FormOwnBag()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
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

        private void BtnStart_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormBasketList, hides the current form, and shows the new form
            FormBasketList formBasketList= new FormBasketList();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
        }

        private void FormOwnBag_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }
    }
}
