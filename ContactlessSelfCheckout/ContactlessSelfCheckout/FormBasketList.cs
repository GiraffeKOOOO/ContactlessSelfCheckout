using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ContactlessSelfCheckout
{
    public partial class FormBasketList : Form
    {
        public string formTitle = "BasketList";
        // public ArrayList orderList = new ArrayList();
        public List<Product> orderList = new List<Product>();

        public FormBasketList()
        {
            InitializeComponent();
        }

        private void BasketListForm_Load(object sender, EventArgs e)
        {

        }
        private void FormBasketList_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("Form shown");
            lblBasketCounter.Text = CounterStringFormatting(orderList.Count);

            foreach (var orderItem in orderList)
            {
                Console.WriteLine("Item is:" + orderItem);
            }

        }

        private string CounterStringFormatting(int counterSize)
        {
            string formattedString = "0";

            if (counterSize < 10) 
            {
                formattedString = $"00" + counterSize.ToString();
            }
            else if (counterSize > 10 && counterSize < 99)
            {
                formattedString = $"0" + counterSize.ToString();
            }
            else if (counterSize > 99)
            {
                formattedString = counterSize.ToString();
            }

            return formattedString;

        }
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            this.Hide();
            formHelp.Show();
        }

        private void BtnVegetables_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormVegetables, hides the current form, and shows the new form
            FormVegetables formVegetables= new FormVegetables();
            this.Hide();
            formVegetables.Show();
        }

    }
}
