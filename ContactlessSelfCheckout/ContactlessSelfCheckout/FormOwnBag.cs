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
            this.Hide();
            formHelp.Show();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormBasketList, hides the current form, and shows the new form
            FormBasketList formBasketList= new FormBasketList();
            this.Hide();
            formBasketList.Show();
        }
    }
}
