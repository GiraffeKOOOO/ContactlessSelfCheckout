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
        public List<Product> basketList = new List<Product>();

        public FormBasketList()
        {
            InitializeComponent();
        }

        public void AddProductToList(Product product) 
        {
            // this function allows for adding of products from buttons in other forms
            basketList.Add(product);
            UpdateCounter();
            CreateListLabel(product.productName, product.productPrice);
            // reposition the labels?
        }

        public void UpdateCounter() 
        {
            // this function should be called whenever the counter needs to be refreshed
            lblBasketCounter.Text = CounterStringFormatting(basketList.Count);
        }

        private void CreateListLabel(String productName, decimal productPrice)
        {
            // this function creates new text labels to appear in the list of products in the basket
            Point nameLabelLocation = new Point(5, 100);
            Point priceLabelLocation = new Point(500, 100);

            Label lblProductName = new Label
            {
                Text = productName,
                Location = nameLabelLocation,
                Font = new Font("Microsoft Sans Serif", 15),
                AutoSize = true,
                ForeColor = Color.Black
            };
            pnlBasketList.Controls.Add(lblProductName);
            lblProductName.BringToFront();

            Label lblProductPrice = new Label
            {
                Text = "£ " + productPrice.ToString(),
                Location = priceLabelLocation,
                Font = new Font("Microsoft Sans Serif", 15),
                AutoSize = true,
                ForeColor = Color.Black
            };
            pnlBasketList.Controls.Add(lblProductPrice);
            lblProductPrice.BringToFront();
        }

        private string CounterStringFormatting(int counterSize)
        {
            // this function is for formatting the counter display, making sure the zeros appear even if the basket count is single or double digit
            string formattedString = "0";

            if (counterSize < 10) 
            {
                formattedString = $"00" + counterSize.ToString();
            }
            else if (counterSize >= 10 || counterSize < 100)
            {
                formattedString = $"0" + counterSize.ToString();
            }
            else if (counterSize >= 100)
            {
                formattedString = counterSize.ToString();
            }

            return formattedString;

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

        private void BtnVegetables_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormVegetables, and shows the new form directly on top of the previous form
            FormVegetables formVegetables = new FormVegetables(this);
            formVegetables.Show();
            formVegetables.Left = this.Left;
            formVegetables.Top = this.Top;
            this.Hide();
        }

        
    }
}
