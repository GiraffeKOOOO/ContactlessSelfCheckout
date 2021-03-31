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
        readonly DatabaseHelper databaseHelper = new DatabaseHelper();
        readonly DataTable dataTable = new DataTable();
        public FormVegetables()
        {
            InitializeComponent();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormHelp formHelp = new FormHelp(formTitle);
            this.Hide();
            formHelp.Show();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormBasketList formBasketList = new FormBasketList();
            this.Hide();
            formBasketList.Show();
        }

        private void FormVegetables_Load(object sender, EventArgs e)
        {
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
                    Size = new Size(120, 90),
                    Location = newLocation,
                    Text = productName
                };

                button.Click += delegate 
                {
                    // creating a product object to be added to the basket list
                    Product product = new Product(productID, productName, productCategory, productPrice, productStock);

                    FormBasketList formBasketList = new FormBasketList();
                    formBasketList.AddProductToList();
                    
                };
                newLocation.Offset(button.Width + 20, 0);
                pnlVegetableItems.Controls.Add(button);
            }

            databaseHelper.CloseConnection();
        }

    }
}
