using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace ContactlessSelfCheckout
{
    public partial class FormBasketList : Form
    {
        // this list is used for storing of products selected by the users, this allows to show the list and calculate the cost
        public List<Product> basketList = new List<Product>();
        public decimal basketTotal = 0;
        public bool removeMode = false;

        public FormBasketList()
        {
            InitializeComponent();
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
            UpdateTotalLbl();
        }

        public void AddProductToList(Product product) 
        {
            // this function creates a product and adds it to the list, then creates labels to appear in the basket list and repositions them
            basketList.Add(product);
            UpdateCounter();
            CreateListLabel(product.productName, product.productPrice, basketList.IndexOf(product));
            RepositionLabels(0);
            CalculateTotal(product.productPrice, true);
            UpdateTotalLbl();
        }

        public void UpdateCounter() 
        {
            // this function should be called whenever the counter needs to be refreshed
            lblBasketCounter.Text = CounterStringFormatting(basketList.Count);
            if (basketList.Count > 0)
            {
                // enable finish and pay button
                btnPayGrey.Visible = false;
                btnPay.Visible = true;
                // enable remove item button
                btnRemoveItemGrey.Visible = false;
                btnRemoveItem.Visible = true;
            }
            else
            {
                // disable finish and pay button
                btnPayGrey.Visible = true;
                btnPay.Visible = false;

                if (removeMode == false)
                {
                    // disable remove item button
                    btnRemoveItemGrey.Visible = true;
                    btnRemoveItem.Visible = false;
                }
                
            }
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

        private void CreateListLabel(String productName, decimal productPrice, int arrayIndex)
        {
            // this function creates new text labels for the product and the price, to appear in the list of products in the basket
            Label lblProductName = new Label
            {
                Name = $"lblProduct{arrayIndex}",
                Text = productName,
                Font = new Font("Microsoft Sans Serif", 25),
                AutoSize = true,
                ForeColor = Color.Black
            };
            pnlBasketList.Controls.Add(lblProductName);
            lblProductName.BringToFront();

            Label lblProductPrice = new Label
            {
                Name = $"lblPrice{arrayIndex}",
                Text = "£ " + productPrice.ToString(),
                Font = new Font("Microsoft Sans Serif", 25),
                AutoSize = true,
                ForeColor = Color.Black
            };
            pnlBasketList.Controls.Add(lblProductPrice);
            lblProductPrice.BringToFront();
        }

        private void RepositionLabels(int xPos)
        {
            // this function repositions the created labels

            // start with creating variables that store all the labels
            var productLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblProduct"));
            var priceLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblPrice"));
            

            // new location starting points
            Point productPoint = new Point(5 + xPos, 60);
            Point pricePoint = new Point(480, 60);
            

            // for each loops to reposition the labels
            foreach (var label in productLabels)
            {
                label.Location = productPoint;
                productPoint.Offset(0, label.Height + 25);
            }

            foreach (var label in priceLabels)
            {
                label.Location = pricePoint;
                pricePoint.Offset(0, label.Height + 25);
            }

            
        }

        private void RepositionDeleteButtoins()
        {
            var deleteItemButtons = pnlBasketList.Controls.OfType<PictureBox>().Where(deleteItemButton => deleteItemButton.Name.StartsWith("btnDeleteItem"));

            Point deleteButtonPoint = new Point(5 , 60);

            foreach (var deleteButton in deleteItemButtons)
            {
                deleteButton.Location = deleteButtonPoint;
                deleteButtonPoint.Offset(0, deleteButton.Height + 25);

            }
        }

        private decimal CalculateTotal(decimal productCost, bool addingProduct)
        {
            // function for calculating the basket total
            if (addingProduct == true)
            {
                basketTotal += productCost;
            }
            else
            {
                basketTotal -= productCost;
            }
            return basketTotal;
        }

        private void UpdateTotalLbl()
        {
            // function for changing the text of the total cost label to match the total cost
            lblTotalSum.Text = "£ " + basketTotal.ToString();   
        }

        private void BtnFruit_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void BtnFruit_MouseEnter(object sender, EventArgs e)
        {
            btnFruit.Image = Properties.Resources.fruit_button_hover;
            btnFruit.Refresh();
        }

        private void BtnFruit_MouseLeave(object sender, EventArgs e)
        {
            btnFruit.Image = Properties.Resources.fruit_button;
            btnFruit.Refresh();
        }

        private void BtnVegetable_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormVegetables, and shows the new form directly on top of the previous form
            FormVegetables formVegetables = new FormVegetables(this);
            formVegetables.Show();
            formVegetables.Left = this.Left;
            formVegetables.Top = this.Top;
            this.Hide();
        }

        private void BtnVegetable_MouseEnter(object sender, EventArgs e)
        {
            btnVegetable.Image = Properties.Resources.vegetables_button_hover;
            btnVegetable.Refresh();
        }

        private void BtnVegetable_MouseLeave(object sender, EventArgs e)
        {
            btnVegetable.Image = Properties.Resources.vegetables_button;
            btnVegetable.Refresh();
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void BtnDrinks_MouseEnter(object sender, EventArgs e)
        {
            btnDrinks.Image = Properties.Resources.drinks_button_hover;
            btnDrinks.Refresh();
        }

        private void BtnDrinks_MouseLeave(object sender, EventArgs e)
        {
            btnDrinks.Image = Properties.Resources.drinks_button;
            btnDrinks.Refresh();
        }

        private void BtnBakery_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void BtnBakery_MouseEnter(object sender, EventArgs e)
        {
            btnBakery.Image = Properties.Resources.bakery_button_hover;
            btnBakery.Refresh();
        }

        private void BtnBakery_MouseLeave(object sender, EventArgs e)
        {
            btnBakery.Image = Properties.Resources.bakery_button;
            btnBakery.Refresh();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void BtnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.search_button_hover;
            btnSearch.Refresh();
        }

        private void BtnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Image = Properties.Resources.search_button;
            btnSearch.Refresh();
        }

        private void BtnBarcode_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void BtnBarcode_MouseEnter(object sender, EventArgs e)
        {
            btnBarcode.Image = Properties.Resources.barcode_button_hover;
            btnBarcode.Refresh();
        }

        private void BtnBarcode_MouseLeave(object sender, EventArgs e)
        {
            btnBarcode.Image = Properties.Resources.barcode_button;
            btnBarcode.Refresh();
        }

        private void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            removeMode = true;

            if (removeMode == true)
            {
                // hide current button to show the done button
                btnRemoveItem.Visible = false;
                btnRemoveItemDone.Visible = true;

                // hide current clickable buttons for product type
                btnFruit.Visible = false;
                btnVegetable.Visible = false;
                btnDrinks.Visible = false;
                btnBakery.Visible = false;
                btnSearch.Visible = false;
                btnBarcode.Visible = false;

                // show greyed out buttons
                btnFruitGrey.Visible = true;
                btnVegetableGrey.Visible = true;
                btnDrinksGrey.Visible = true;
                btnBakeryGrey.Visible = true;
                btnSearchGrey.Visible = true;
                btnBarcodeGrey.Visible = true;

                RepositionLabels(50);
                // start with creating variables that store all the labels
                var productLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblProduct"));

                Point newLocation = new Point(10, 60);

                foreach (var product in productLabels)
                {
                    int productNumber = Int32.Parse(product.Name.Substring(10));

                    PictureBox btnDeleteItem = new PictureBox
                    {
                        Name = $"btnDeleteItem{productNumber}",
                        Size = new Size(39, 39),
                        Location = newLocation,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        BackColor = Color.FromArgb(0xff8400),
                        Image = Properties.Resources.delete_button
                    };

                    btnDeleteItem.Click += delegate
                    {
                        RemoveItem(productNumber);
                    };

                    // adjusting the location for the next button
                    pnlBasketList.Controls.Add(btnDeleteItem);
                    newLocation.Offset(0, btnDeleteItem.Size.Height + 25);
                }
            }

        }

        private void RemoveItem(int basketListIndex)
        {
            RemoveComponents(basketListIndex);
            try
            {
                CalculateTotal(basketList.ElementAt(basketListIndex).productPrice, false);
                UpdateTotalLbl();
                basketList.RemoveAt(basketListIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured: " + e );
            }
            UpdateCounter();
            RepositionLabels(50);
            RepositionDeleteButtoins();

        }

        private void RemoveComponents(int basketListIndex)
        {
            var productLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblProduct"));
            var priceLabels = pnlBasketList.Controls.OfType<Label>().Where(label => label.Name.StartsWith("lblPrice"));
            var deleteItemButtons = pnlBasketList.Controls.OfType<PictureBox>().Where(deleteItemButton => deleteItemButton.Name.StartsWith("btnDeleteItem"));

            foreach (var productLabel in productLabels)
            {
                if (productLabel.Name.Contains(basketListIndex.ToString()))
                {
                    pnlBasketList.Controls.Remove(productLabel);
                }
            }

            foreach (var priceLabel in priceLabels)
            {
                if (priceLabel.Name.Contains(basketListIndex.ToString()))
                {
                    pnlBasketList.Controls.Remove(priceLabel);
                }
            }

            foreach (var removeButton in deleteItemButtons)
            {
                if (removeButton.Name.Contains(basketListIndex.ToString()))
                {
                    pnlBasketList.Controls.Remove(removeButton);
                }
            }
        }

        private void BtnRemoveItem_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveItem.Image = Properties.Resources.remove_item_button_hover;
            btnRemoveItem.Refresh();
        }

        private void BtnRemoveItem_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveItem.Image = Properties.Resources.remove_item_button;
            btnRemoveItem.Refresh();
        }

        private void BtnRemoveItemDone_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            removeMode = false;
            
            // start with creating variables that store all the delete buttons
            var deleteItemButtons = pnlBasketList.Controls.OfType<PictureBox>().Where(deleteItemButton => deleteItemButton.Name.StartsWith("btnDeleteItem"));

            if (removeMode == false)
            {
                // hide current done button to show the remove item button
                btnRemoveItemDone.Visible = false;
                btnRemoveItem.Visible = true;

                // hide greyed out buttons 
                btnFruit.Visible = true;
                btnVegetable.Visible = true;
                btnDrinks.Visible = true;
                btnBakery.Visible = true;
                btnSearch.Visible = true;
                btnBarcode.Visible = true;

                // show current clickable buttons for product type
                btnFruitGrey.Visible = false;
                btnVegetableGrey.Visible = false;
                btnDrinksGrey.Visible = false;
                btnBakeryGrey.Visible = false;
                btnSearchGrey.Visible = false;
                btnBarcodeGrey.Visible = false;

                foreach (var deleteButton in deleteItemButtons)
                {
                    pnlBasketList.Controls.Remove(deleteButton);
                }
            }
        }

        private void BtnRemoveItemDone_MouseEnter(object sender, EventArgs e)
        {
            btnRemoveItemDone.Image = Properties.Resources.remove_item_button_done_hover;
            Refresh();
        }

        private void BtnRemoveItemDone_MouseLeave(object sender, EventArgs e)
        {
            btnRemoveItemDone.Image = Properties.Resources.remove_item_button_done;
            Refresh();
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            BtnRemoveItemDone_Click(sender, e);
            CursorAnimate();
            FormPay formPay = new FormPay(this);
            formPay.Show();
            formPay.Left = this.Left;
            formPay.Top = this.Top;
            this.Hide();
        }

        private void BtnPay_MouseEnter(object sender, EventArgs e)
        {
            btnPay.Image = Properties.Resources.finish_and_pay_button_hover;
            btnPay.Refresh();
        }

        private void BtnPay_MouseLeave(object sender, EventArgs e)
        {
            btnPay.Image = Properties.Resources.finish_and_pay_button;
            btnPay.Refresh();
        }

        private void BtnHelp_Click(object sender, EventArgs e)
        {
            CursorAnimate();
            // This function creates a new object for the FormHelp, hides the current form, and shows the new form
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

        private void FormBasketList_Click(object sender, EventArgs e)
        {
            CursorAnimate();
        }

        private void FormBasketList_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseProcess("KinectV2MouseControl");
        }

        private void CursorAnimate()
        {
            this.Cursor = new Cursor(Application.StartupPath + "\\hand-clicked.cur");
            Thread.Sleep(100);
            this.Cursor = new Cursor(Application.StartupPath + "\\hand.cur");
        }

        private void CloseProcess(string name)
        {
            foreach (Process process in Process.GetProcesses())
            {
                if (process.ProcessName.Contains(name))
                {
                    process.Kill();
                }
            }
        }

        
    }
}
