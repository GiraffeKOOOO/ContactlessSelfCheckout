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
        // this list is used for storing of products selected by the users, this allows to show the list and calculate the cost
        public List<Product> basketList = new List<Product>();
        public decimal basketTotal = 0;

        public FormBasketList()
        {
            InitializeComponent();
        }

        public void AddProductToList(Product product) 
        {
            // this function creates a product and adds it to the list, then creates labels to appear in the basket list and repositions them
            basketList.Add(product);
            UpdateCounter();
            CreateListLabel(product.productName, product.productPrice);
            RepositionLabels();
            CalculateTotal(product.productPrice);
            UpdateTotalLbl();
        }

        public void UpdateCounter() 
        {
            // this function should be called whenever the counter needs to be refreshed
            lblBasketCounter.Text = CounterStringFormatting(basketList.Count);
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

        private void CreateListLabel(String productName, decimal productPrice)
        {
            // this function creates new text labels for the product and the price, to appear in the list of products in the basket
            Label lblProductName = new Label
            {
                Name = "lblProduct",
                Text = productName,
                Font = new Font("Microsoft Sans Serif", 15),
                AutoSize = true,
                ForeColor = Color.Black
            };
            pnlBasketList.Controls.Add(lblProductName);
            lblProductName.BringToFront();

            Label lblProductPrice = new Label
            {
                Name = "lblPrice",
                Text = "£ " + productPrice.ToString(),
                Font = new Font("Microsoft Sans Serif", 15),
                AutoSize = true,
                ForeColor = Color.Black
            };
            pnlBasketList.Controls.Add(lblProductPrice);
            lblProductPrice.BringToFront();
        }

        private void RepositionLabels()
        {
            // this function repositions the created labels

            // start with creating variables that store all the labels
            var productLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblProduct"));
            var priceLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblPrice"));

            // new location starting points
            Point productPoint = new Point(5, 60);
            Point pricePoint = new Point(500, 60);

            // for each loops to reposition the labels
            foreach (var label in productLabels)
            {
                label.Location = productPoint;
                productPoint.Offset(0, label.Height + 5);
            }

            foreach (var label in priceLabels)
            {
                label.Location = pricePoint;
                pricePoint.Offset(0, label.Height + 5);
            }
        }

        private decimal CalculateTotal(decimal productCost)
        {
            // function for calculating the basket total
            basketTotal += productCost;
            return basketTotal;
        }
        private void UpdateTotalLbl()
        {
            // function for changing the text of the total cost label to match the total cost
            lblTotalSum.Text = "£ " + basketTotal.ToString();   
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
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
