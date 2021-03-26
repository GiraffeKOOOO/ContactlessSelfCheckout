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
    public partial class FormBasketList : Form
    {
        public string formTitle = "BasketList";
        private Object[] basket = new Object[3] { "Cucumber", "Pear", "Coconut"};
        public FormBasketList()
        {
            InitializeComponent();
        }

        private void BasketListForm_Load(object sender, EventArgs e)
        {
            Product myItem = new Product();
            Console.WriteLine(myItem.itemPrice);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            this.Hide();
            formHelp.Show();
        }

        private void btnVegetables_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormVegetables, hides the current form, and shows the new form
            FormVegetables formVegetables= new FormVegetables();
            this.Hide();
            formVegetables.Show();
        }

        private void imgTableBorder_Click(object sender, EventArgs e)
        {

        }

        private void lblBasketCounter_Click(object sender, EventArgs e)
        {

        }
    }
}
