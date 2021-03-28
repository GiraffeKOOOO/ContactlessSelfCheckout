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
    public partial class FormVegetables : Form
    {
        public string formTitle = "Vegetables";
        DatabaseHelper databaseHelper = new DatabaseHelper();
        DataTable dataTable = new DataTable();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
            FormBasketList formBasketList = new FormBasketList();
            this.Hide();
            formBasketList.Show();
        }

        private void FormVegetables_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'db_ProductsDataSet.Table_Product' table.
            this.table_ProductTableAdapter.Fill(this.db_ProductsDataSet.Table_Product);
            string sqlQuery = "SELECT * FROM Table_Product WHERE Product_Category ='Vegetable';";
            databaseHelper.readDataThroughAdapter(sqlQuery, dataTable);

            Point newLocation = new Point(5, 5);
            foreach (DataRow row in dataTable.Rows)
            {
                string vegetableName = row["Product_Name"].ToString();

                Button button = new Button
                {
                    Size = new Size(120, 90),
                    Location = newLocation,
                    Text = vegetableName
                };

                button.Click += delegate 
                {
                    Product vegetable = new Product(row["Product_ID"], row["Product_Name"].ToString(), row["Product_Category"].ToString(), (double)row["Product_Price"], (int)row["Product_Stock"]);
                    Console.WriteLine(vegetable);
                };
                newLocation.Offset(button.Width + 20, 0);
                pnlVegetableItems.Controls.Add(button);
            }

            databaseHelper.closeConnection();
        }

    }
}
