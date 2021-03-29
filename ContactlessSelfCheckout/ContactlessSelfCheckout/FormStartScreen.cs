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
            this.Hide();
            formBasketList.Show();
        }

        private void OwnBagButton_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormOwnBag, hides the current form, and shows the new form
            FormOwnBag formOwnBag= new FormOwnBag();
            this.Hide();
            formOwnBag.Show();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            this.Hide();
            formHelp.Show();
        }
    }
}
