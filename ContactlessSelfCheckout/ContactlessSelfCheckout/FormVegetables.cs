using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace ContactlessSelfCheckout
{
    public partial class FormVegetables : Form
    {
        private readonly FormBasketList formBasketList;
        readonly DatabaseHelper databaseHelper = new DatabaseHelper();
        readonly DataTable dataTable = new DataTable();

        /// <summary>
        /// This is the form constructor which tkaes in the form basket lsit reference to maintain state
        /// </summary>
        /// <param name="formBasketListRef">FormBasketList object that gets passed in to maintain state</param>
        public FormVegetables(FormBasketList formBasketListRef)
        {
            formBasketList = formBasketListRef;
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }
        
        
        /// <summary>
        /// This function creates the alphabet search buttons, utilising loops and arrays to create the buttons
        /// </summary>
        private void GenerateAlphabet()
        {
            // this function generates the clickable alphabet at the top of the form that allows for filtering

            // initialising the alphabet array
            char[] alphabet = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            char[] alphabet2 = { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            // initialising the array of buttons created
            var vegetableButtons = pnlVegetableItems.Controls.OfType<Button>();

            // dimensions of the panel, used for calculations of button width
            int maxWidth = pnlAlphabet.Width;
            int maxHeight = pnlAlphabet.Height;
            int maxButtonWidth = (maxWidth / (alphabet.Length + alphabet2.Length)) * 2;

            // creating a new point variable to allow for the product buttons to be in different locations
            Point newLocation = new Point(4, 3);
            Point newLocation2 = new Point(4, 70);

            // foreach loop to go over the characters in the alphabet and create them in to buttons
            foreach (char letter in alphabet)
            {
                Button characterButton = new Button
                {
                    Name = letter.ToString(),
                    Size = new Size(maxButtonWidth - 5, (maxHeight / 2) - 3),
                    Location = newLocation,
                    Text = letter.ToString(),
                    Font = new Font("Microsoft Sans Serif", 16),
                    BackColor = Color.Orange
                };

                characterButton.Click += delegate
                {
                    CursorAnimate();
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

            foreach (char letter in alphabet2)
            {
                Button characterButton = new Button
                {
                    Name = letter.ToString(),
                    Size = new Size(maxButtonWidth - 5, (maxHeight / 2) - 3),
                    Location = newLocation2,
                    Text = letter.ToString(),
                    Font = new Font("Microsoft Sans Serif", 16),
                    BackColor = Color.Orange
                };

                characterButton.Click += delegate
                {
                    CursorAnimate();
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
                newLocation2.Offset(characterButton.Width + 5, 0);
                // adding the character buttons to the alphabet search panel
                pnlAlphabet.Controls.Add(characterButton);
            }
        }

        /// <summary>
        /// This function creates the product buttons by getting the data from the database, and using loops to create all the buttons that get returned
        /// </summary>
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
                    Size = new Size(160, 75),
                    Location = newLocation,
                    Text = productName,
                    Font = new Font("Microsoft Sans Serif", 12),
                };

                button.Click += delegate
               {
                   CursorAnimate();
                   // get the quantity from the user by creating the quantity screen and passing down all the props to create the products in a for loop
                   FormQuantityScreen formQuantityScreen = new FormQuantityScreen(this, productID, productName, productCategory, productPrice, productStock);
                   formQuantityScreen.Show();
                   formQuantityScreen.Top = this.Top;
                   formQuantityScreen.Left = this.Left;
                   this.Hide();
               };
                // adjusting the location for the next button
                newLocation.Offset(button.Width + 30, 0);
                // adding the button to the main panel of this form
                pnlVegetableItems.Controls.Add(button);
            }
            databaseHelper.CloseConnection();
        }

        /// <summary>
        /// This function is called from the quantity selection screen, where the product gets created as quantity is assigned in that form
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="productName"></param>
        /// <param name="productCategory"></param>
        /// <param name="productPrice"></param>
        /// <param name="productStock"></param>
        public void AddProduct(int productID, string productName, string productCategory, decimal productPrice, int productStock)
        {
            Product product = new Product(productID, productName, productCategory, productPrice, productStock);
            formBasketList.AddProductToList(product);
        }

        /// <summary>
        /// this function is for being used in the quantity screen for closing this form and going back to the basket list
        /// </summary>
        public void CloseVegetableForm()
        {
            CursorAnimate();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
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

        /// <summary>
        /// This function hides the current form returning the user to the basket list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBack_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
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

        private void FormVegetables_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormVegetables_Load(object sender, EventArgs e)
        {
            GenerateAlphabet();
            GenerateButtons();
        }

        /// <summary>
        /// this function is for being used in the quantity screen for closing this form and going back to the basket list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVegetables_FormClosed(object sender, FormClosedEventArgs e)
        {
            formBasketList.Show();
            formBasketList.Left = this.Left;
            formBasketList.Top = this.Top;
            this.Hide();
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
