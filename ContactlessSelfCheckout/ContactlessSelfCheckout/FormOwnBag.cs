using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
            this.Hide();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormBasketList, hides the current form, and shows the new form
            FormBasketList formBasketList= new FormBasketList();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
        }
    }
}
