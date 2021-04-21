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
    public partial class FormQuantityScreen : Form
    {
        public int Quantity { get; set;}
        

        public FormQuantityScreen()
        {
            InitializeComponent();
        }

        private void FormQuantityScreen_Load(object sender, EventArgs e)
        {
            Quantity = 0;
            // quantitySelected = false;
            UpdateQuantity();
            GenerateButtons();
        }

        private void UpdateQuantity()
        {
            lblQuantity.Text = Quantity.ToString();
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
                    Quantity += number;
                    UpdateQuantity();
                };

                // adjusting the location for the next button
                newLocation.Offset(numberButton.Width + 5, 0);
                pnlNumpad.Controls.Add(numberButton);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // quantitySelected = true;
            this.Close();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Quantity = 0;
            UpdateQuantity();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
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
