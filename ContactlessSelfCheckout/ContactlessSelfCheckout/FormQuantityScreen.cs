using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ContactlessSelfCheckout
{
    public partial class FormQuantityScreen : Form
    {
        private readonly FormVegetables formVegetables;
        // taking in paramaters for adding products
        private readonly int productIDRef;
        private readonly string productNameRef;
        private readonly string productCategoryRef;
        private readonly decimal productPriceRef;
        private readonly int productStockRef;

        private int quantity;

        /// <summary>
        /// This function takes in the reference values from the vegetable product list form, this is because this form is where the product is created as it requires quantity
        /// quantity is later on used to call the create product function depending on what the quantity has been set to
        /// </summary>
        /// <param name="formVegetablesRef">FormVegetable reference</param>
        /// <param name="productID"></param>
        /// <param name="productName"></param>
        /// <param name="productCategory"></param>
        /// <param name="productPrice"></param>
        /// <param name="productStock"></param>
        public FormQuantityScreen(FormVegetables formVegetablesRef, int productID, string productName, string productCategory, decimal productPrice, int productStock)
        {
            formVegetables = formVegetablesRef;
            productIDRef = productID;
            productNameRef = productName;
            productCategoryRef = productCategory;
            productPriceRef = productPrice;
            productStockRef = productStock;
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        /// <summary>
        /// This function updates the quantity label
        /// </summary>
        private void UpdateQuantity()
        {
            lblQuantity.Text = quantity.ToString();
        }

        /// <summary>
        /// This function generates the numpad buttons and assigns them to the numpad grid
        /// </summary>
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
                    CursorAnimate();
                    quantity = number;
                    UpdateQuantity();
                };

                // adjusting the location for the next button
                newLocation.Offset(numberButton.Width + 5, 0);
                pnlNumpad.Controls.Add(numberButton);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // use the quantity in the for loop for creating products, then close both forms
            for (int i = 0; i < quantity; i++)
            {
                formVegetables.AddProduct(productIDRef, productNameRef, productCategoryRef, productPriceRef, productStockRef);
            }
            formVegetables.CloseVegetableForm();
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // quantity needs to be reset 0
            quantity = 0;
            UpdateQuantity();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            formVegetables.Show();
            formVegetables.Left = this.Left;
            formVegetables.Top = this.Top;
            this.Close();
        }

        private void BtnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.back_button_hover;
            btnBack.Refresh();
        }

        private void BtnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Image = Properties.Resources.back_button;
            btnBack.Refresh();
        }

        /// <summary>
        /// This function creates a new object for the FormHelp, hides the current form, and shows the new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
        }

        private void BtnHelp_MouseEnter(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.help_button_hover;
            btnHelp.Refresh();
        }

        private void BtnHelp_MouseLeave(object sender, EventArgs e)
        {
            btnHelp.Image = Properties.Resources.help_button;
            btnHelp.Refresh();
        }

        private void FormQuantityScreen_Load(object sender, EventArgs e)
        {
            quantity = 0;
            UpdateQuantity();
            GenerateButtons();
        }

        private void FormQuantityScreen_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        /// <summary>
        /// This function is called when the mouse is clicked, this function shows a little animation of the hand cursor being grasped by simply changing the image and changing it back
        /// </summary>
        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        
    }
}
