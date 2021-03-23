﻿using System;
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
    public partial class FormBasketList : Form
    {
        public string formTitle = "BasketList";
        public FormBasketList()
        {
            InitializeComponent();
        }

        private void BasketListForm_Load(object sender, EventArgs e)
        {
            Item myItem = new Item();
            Console.WriteLine(myItem.itemPrice);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            this.Hide();
            formHelp.Show();
        }
    }
}