using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ContactlessSelfCheckout
{
    public partial class FormStartScreen : Form
    {
        public string formTitle = "Start";
        public FormStartScreen()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormBasketList, hides the current form, and shows the new form
            FormBasketList formBasketList = new FormBasketList();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
        }

        private void OwnBagButton_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormOwnBag, hides the current form, and shows the new form
            FormOwnBag formOwnBag= new FormOwnBag();
            formOwnBag.Show();
            formOwnBag.Left = this.Left;
            formOwnBag.Top = this.Top;
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
            this.Hide();
        }
    }
}
