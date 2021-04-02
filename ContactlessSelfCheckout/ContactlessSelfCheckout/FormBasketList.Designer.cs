namespace ContactlessSelfCheckout
{
    partial class FormBasketList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBasketList));
            this.lblBasketList = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblBasket = new System.Windows.Forms.Label();
            this.imgShoppingCart = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.btnFruit = new System.Windows.Forms.Button();
            this.btnBakery = new System.Windows.Forms.Button();
            this.btnMultipack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBarcode = new System.Windows.Forms.Button();
            this.lblBasketCounter = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pnlBasketList = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.imgItemCounterBorder = new System.Windows.Forms.PictureBox();
            this.imgTitleBorder = new System.Windows.Forms.PictureBox();
            this.imgTotalBorder = new System.Windows.Forms.PictureBox();
            this.imgTableBorder = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgShoppingCart)).BeginInit();
            this.pnlBasketList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgItemCounterBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTableBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBasketList
            // 
            this.lblBasketList.AutoSize = true;
            this.lblBasketList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBasketList.Location = new System.Drawing.Point(12, 16);
            this.lblBasketList.Name = "lblBasketList";
            this.lblBasketList.Size = new System.Drawing.Size(153, 25);
            this.lblBasketList.TabIndex = 0;
            this.lblBasketList.Text = "Your Basket List";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblInstruction.Location = new System.Drawing.Point(650, 41);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(298, 29);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please scan your next item";
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBasket.Location = new System.Drawing.Point(299, 18);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(163, 25);
            this.lblBasket.TabIndex = 2;
            this.lblBasket.Text = "item in the basket";
            // 
            // imgShoppingCart
            // 
            this.imgShoppingCart.Image = ((System.Drawing.Image)(resources.GetObject("imgShoppingCart.Image")));
            this.imgShoppingCart.Location = new System.Drawing.Point(209, 12);
            this.imgShoppingCart.Name = "imgShoppingCart";
            this.imgShoppingCart.Size = new System.Drawing.Size(33, 31);
            this.imgShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShoppingCart.TabIndex = 3;
            this.imgShoppingCart.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Silver;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHelp.Location = new System.Drawing.Point(12, 627);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(118, 90);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.button1.Location = new System.Drawing.Point(669, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 82);
            this.button1.TabIndex = 8;
            this.button1.Text = "Finish and Pay";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnVegetables
            // 
            this.btnVegetables.BackColor = System.Drawing.Color.Silver;
            this.btnVegetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnVegetables.Location = new System.Drawing.Point(614, 107);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(181, 101);
            this.btnVegetables.TabIndex = 10;
            this.btnVegetables.Text = "Vegetables";
            this.btnVegetables.UseVisualStyleBackColor = false;
            this.btnVegetables.Click += new System.EventHandler(this.BtnVegetables_Click);
            // 
            // btnFruit
            // 
            this.btnFruit.BackColor = System.Drawing.Color.Silver;
            this.btnFruit.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnFruit.Location = new System.Drawing.Point(815, 107);
            this.btnFruit.Name = "btnFruit";
            this.btnFruit.Size = new System.Drawing.Size(181, 101);
            this.btnFruit.TabIndex = 11;
            this.btnFruit.Text = "Fruit";
            this.btnFruit.UseVisualStyleBackColor = false;
            // 
            // btnBakery
            // 
            this.btnBakery.BackColor = System.Drawing.Color.Silver;
            this.btnBakery.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnBakery.Location = new System.Drawing.Point(614, 268);
            this.btnBakery.Name = "btnBakery";
            this.btnBakery.Size = new System.Drawing.Size(181, 101);
            this.btnBakery.TabIndex = 12;
            this.btnBakery.Text = "Bakery";
            this.btnBakery.UseVisualStyleBackColor = false;
            // 
            // btnMultipack
            // 
            this.btnMultipack.BackColor = System.Drawing.Color.Silver;
            this.btnMultipack.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnMultipack.Location = new System.Drawing.Point(815, 268);
            this.btnMultipack.Name = "btnMultipack";
            this.btnMultipack.Size = new System.Drawing.Size(181, 101);
            this.btnMultipack.TabIndex = 13;
            this.btnMultipack.Text = "Multipack";
            this.btnMultipack.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnSearch.Location = new System.Drawing.Point(614, 420);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(181, 101);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnBarcode
            // 
            this.btnBarcode.BackColor = System.Drawing.Color.Silver;
            this.btnBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBarcode.Location = new System.Drawing.Point(815, 422);
            this.btnBarcode.Name = "btnBarcode";
            this.btnBarcode.Size = new System.Drawing.Size(181, 101);
            this.btnBarcode.TabIndex = 15;
            this.btnBarcode.Text = "Enter barcode number";
            this.btnBarcode.UseVisualStyleBackColor = false;
            // 
            // lblBasketCounter
            // 
            this.lblBasketCounter.AutoSize = true;
            this.lblBasketCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBasketCounter.Location = new System.Drawing.Point(248, 18);
            this.lblBasketCounter.Name = "lblBasketCounter";
            this.lblBasketCounter.Size = new System.Drawing.Size(45, 25);
            this.lblBasketCounter.TabIndex = 16;
            this.lblBasketCounter.Text = "000";
            this.lblBasketCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(12, 582);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalSum.Location = new System.Drawing.Point(455, 578);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(110, 25);
            this.lblTotalSum.TabIndex = 18;
            this.lblTotalSum.Text = "£1,000,000";
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.Silver;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRemoveItem.Location = new System.Drawing.Point(263, 627);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(152, 90);
            this.btnRemoveItem.TabIndex = 19;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemName.Location = new System.Drawing.Point(7, 61);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(49, 25);
            this.lblItemName.TabIndex = 20;
            this.lblItemName.Text = "Item";
            // 
            // pnlBasketList
            // 
            this.pnlBasketList.Controls.Add(this.pictureBox1);
            this.pnlBasketList.Controls.Add(this.pictureBox2);
            this.pnlBasketList.Controls.Add(this.lblItemPrice);
            this.pnlBasketList.Controls.Add(this.lblTotalSum);
            this.pnlBasketList.Controls.Add(this.imgItemCounterBorder);
            this.pnlBasketList.Controls.Add(this.lblItemName);
            this.pnlBasketList.Controls.Add(this.imgTitleBorder);
            this.pnlBasketList.Controls.Add(this.imgTotalBorder);
            this.pnlBasketList.Controls.Add(this.imgTableBorder);
            this.pnlBasketList.Location = new System.Drawing.Point(5, 4);
            this.pnlBasketList.Name = "pnlBasketList";
            this.pnlBasketList.Size = new System.Drawing.Size(596, 617);
            this.pnlBasketList.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(3, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 1);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(476, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1, 498);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemPrice.Location = new System.Drawing.Point(510, 61);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(56, 25);
            this.lblItemPrice.TabIndex = 26;
            this.lblItemPrice.Text = "Price";
            // 
            // imgItemCounterBorder
            // 
            this.imgItemCounterBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgItemCounterBorder.Location = new System.Drawing.Point(192, 3);
            this.imgItemCounterBorder.Name = "imgItemCounterBorder";
            this.imgItemCounterBorder.Size = new System.Drawing.Size(286, 43);
            this.imgItemCounterBorder.TabIndex = 24;
            this.imgItemCounterBorder.TabStop = false;
            // 
            // imgTitleBorder
            // 
            this.imgTitleBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitleBorder.Location = new System.Drawing.Point(2, 3);
            this.imgTitleBorder.Name = "imgTitleBorder";
            this.imgTitleBorder.Size = new System.Drawing.Size(169, 43);
            this.imgTitleBorder.TabIndex = 23;
            this.imgTitleBorder.TabStop = false;
            // 
            // imgTotalBorder
            // 
            this.imgTotalBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTotalBorder.Location = new System.Drawing.Point(2, 566);
            this.imgTotalBorder.Name = "imgTotalBorder";
            this.imgTotalBorder.Size = new System.Drawing.Size(593, 50);
            this.imgTotalBorder.TabIndex = 22;
            this.imgTotalBorder.TabStop = false;
            // 
            // imgTableBorder
            // 
            this.imgTableBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTableBorder.Location = new System.Drawing.Point(2, 52);
            this.imgTableBorder.Name = "imgTableBorder";
            this.imgTableBorder.Size = new System.Drawing.Size(593, 498);
            this.imgTableBorder.TabIndex = 25;
            this.imgTableBorder.TabStop = false;
            // 
            // FormBasketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.lblBasketCounter);
            this.Controls.Add(this.btnBarcode);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMultipack);
            this.Controls.Add(this.btnBakery);
            this.Controls.Add(this.btnFruit);
            this.Controls.Add(this.btnVegetables);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.imgShoppingCart);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblBasketList);
            this.Controls.Add(this.pnlBasketList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBasketList";
            this.Text = "Contactless Self-Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.imgShoppingCart)).EndInit();
            this.pnlBasketList.ResumeLayout(false);
            this.pnlBasketList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgItemCounterBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTableBorder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasketList;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.PictureBox imgShoppingCart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVegetables;
        private System.Windows.Forms.Button btnFruit;
        private System.Windows.Forms.Button btnBakery;
        private System.Windows.Forms.Button btnMultipack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBarcode;
        private System.Windows.Forms.Label lblBasketCounter;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel pnlBasketList;
        private System.Windows.Forms.PictureBox imgItemCounterBorder;
        private System.Windows.Forms.PictureBox imgTitleBorder;
        private System.Windows.Forms.PictureBox imgTotalBorder;
        private System.Windows.Forms.PictureBox imgTableBorder;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}