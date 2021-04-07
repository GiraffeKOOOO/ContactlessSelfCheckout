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
    public partial class FormVegetables : Form
    {
        public readonly string formTitle = "Vegetables";
        private readonly FormBasketList formBasketList ;
        readonly DatabaseHelper databaseHelper = new DatabaseHelper();
        readonly DataTable dataTable = new DataTable();
        public FormVegetables(FormBasketList formBasketListRef)
        {
            formBasketList = formBasketListRef;
            InitializeComponent();
        }
        private void FormVegetables_Load(object sender, EventArgs e)
        {
            GenerateButtons();
            GenerateAlphabet();
        }


        private void GenerateButtons()
        {
            // this function collects all the items in the database that are vegetables, and creates them in to buttons

            // Load data into the 'db_ProductsDataSet.Table_Product' table.
            this.table_ProductTableAdapter.Fill(this.db_ProductsDataSet.Table_Product);

            // Specifying the query to only select products of category 'Vegetable'
            string sqlQuery = "SELECT * FROM Table_Product WHERE Product_Category ='Vegetable';";
            databaseHelper.ReadDataThroughAdapter(sqlQuery, dataTable);

            // creating a new point variable to allow for the product buttons to be in different locations
            Point newLocation = new Point(5, 5);

            // foreach loop to iterate through the products pulled from the database
            foreach (DataRow row in dataTable.Rows)
            {
                // storing the data from the database in to variables for easier manipulation and object creation
                int productID = (int)row["Product_ID"];
                string productName = row["Product_Name"].ToString();
                string productCategory = row["Product_Category"].ToString();
                decimal productPrice = (decimal)row["Product_Price"];
                int productStock = (int)row["Product_Stock"];


                // changing the properties of the button based on the details of the product from the database
                Button button = new Button
                {
                    Name = productName,
                    Size = new Size(120, 80),
                    Location = newLocation,
                    Text = productName,
                    Font = new Font("Microsoft Sans Serif", 12),

                };

                button.Click += delegate
                {
                    // creating a product object to be added to the basket list
                    Product product = new Product(productID, productName, productCategory, productPrice, productStock);
                    formBasketList.AddProductToList(product);
                };
                // adjusting the location for the next button
                newLocation.Offset(button.Width + 30, 0);
                // adding the button to the main panel of this form
                pnlVegetableItems.Controls.Add(button);
            }

            databaseHelper.CloseConnection();
        }

        private void GenerateAlphabet()
        {
            // this function generates the clickable alphabet at the top of the form that allows for filtering

            // initialising the alphabet array
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            // initialising the array of buttons created
            var vegetableButtons = pnlVegetableItems.Controls.OfType<Button>();
            
            // dimensions of the panel, used for calculations of button width
            int maxWidth = pnlAlphabet.Width;
            int maxButtonWidth = maxWidth / alphabet.Length;

            // creating a new point variable to allow for the product buttons to be in different locations
            Point newLocation = new Point(4, 6);

            // foreach loop to go over the characters in the alphabet and create them in to buttons
            foreach (var letter in alphabet)
            {
                Button characterButton = new Button
                {
                    Name = letter.ToString(),
                    Size = new Size(maxButtonWidth-5, 35),
                    Location = newLocation,
                    Text = letter.ToString(),
                    Font = new Font("Microsoft Sans Serif", 16),
                };

                characterButton.Click += delegate
                {
                    Point sortedLocation = new Point(5, 5);
                    foreach (var vegetableButton in vegetableButtons)
                    {
                        // show all the buttons to allow for looping
                        vegetableButton.Show();

                        if (!vegetableButton.Text.StartsWith(characterButton.Name))
                        {
                            vegetableButton.Hide();
                        }
                        else
                        {
                            vegetableButton.Location = sortedLocation;
                            sortedLocation.Offset(vegetableButton.Width + 30, 0);
                        }
                    }
                };

                // adjusting the location for the next button
                newLocation.Offset(characterButton.Width + 5, 0);
                // adding the character buttons to the alphabet search panel
                pnlAlphabet.Controls.Add(characterButton);
            }
        }
        private void BtnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp();
            formHelp.Show();
            formHelp.Left = this.Left;
            formHelp.Top = this.Top;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // This function hides the current form returning the user to the basket list
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
        }

    }
}
