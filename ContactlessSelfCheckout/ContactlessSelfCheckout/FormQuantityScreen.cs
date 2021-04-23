using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormQuantityScreen : Form
    {
        private readonly FormVegetables parent;
        // taking in paramaters for adding products
        private readonly int productIDRef;
        private readonly string productNameRef;
        private readonly string productCategoryRef;
        private readonly decimal productPriceRef;
        private readonly int productStockRef;

        private int quantity;
        public FormQuantityScreen(FormVegetables _parent, int productID, string productName, string productCategory, decimal productPrice, int productStock)
        {
            parent = _parent;
            productIDRef = productID;
            productNameRef = productName;
            productCategoryRef = productCategory;
            productPriceRef = productPrice;
            productStockRef = productStock;
            InitializeComponent();
        }

        private void FormQuantityScreen_Load(object sender, EventArgs e)
        {
            quantity = 0;
            UpdateQuantity();
            GenerateButtons();
        }

        private void UpdateQuantity()
        {
            lblQuantity.Text = quantity.ToString();
        }

        private void GenerateButtons() 
        {
            int[] numpadNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int buttonWidth = (pnlNumpad.Width) / 3;
            int buttonHeight = (pnlNumpad.Height) / 3;

            // creating a new point variable to allow for the product buttons to be in different locations
            Point newLocation = new Point(4, 6);

            foreach (var number in numpadNumbers)
            {
                Button numberButton = new Button
                {
                    Name = number.ToString(),
                    Size = new Size(buttonWidth, buttonHeight),
                    Location = newLocation,
                    Text = number.ToString(),
                    Font = new Font("Microsoft Sans Serif", 16),
                };

                numberButton.Click += delegate
                {
                    quantity += number;
                    UpdateQuantity();
                };

                // adjusting the location for the next button
                newLocation.Offset(numberButton.Width + 5, 0);
                pnlNumpad.Controls.Add(numberButton);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // use the quantity in the for loop for creating products, then close both forms
            for (int i = 0; i < quantity; i++)
            {
                parent.AddProduct(productIDRef, productNameRef, productCategoryRef, productPriceRef, productStockRef);
            }
            parent.CloseVegetableForm();
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // quantity needs to be reset 0
            quantity = 0;
            UpdateQuantity();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            parent.Show();
            parent.Left = this.Left;
            parent.Top = this.Top;
            this.Close();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
        }

        
    }
}
