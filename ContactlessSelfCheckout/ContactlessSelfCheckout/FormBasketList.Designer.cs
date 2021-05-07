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
            this.btnPay = new System.Windows.Forms.Button();
            this.btnVegetables = new System.Windows.Forms.Button();
            this.lblBasketCounter = new System.Windows.Forms.Label();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblItemName = new System.Windows.Forms.Label();
            this.pnlBasketList = new System.Windows.Forms.Panel();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgShoppingCart)).BeginInit();
            this.pnlBasketList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBasketList
            // 
            this.lblBasketList.AutoSize = true;
            this.lblBasketList.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.lblInstruction.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.lblBasket.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBasket.Location = new System.Drawing.Point(299, 18);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(163, 25);
            this.lblBasket.TabIndex = 2;
            this.lblBasket.Text = "item in the basket";
            // 
            // imgShoppingCart
            // 
            this.imgShoppingCart.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgShoppingCart.Image = ((System.Drawing.Image)(resources.GetObject("imgShoppingCart.Image")));
            this.imgShoppingCart.Location = new System.Drawing.Point(209, 14);
            this.imgShoppingCart.Name = "imgShoppingCart";
            this.imgShoppingCart.Size = new System.Drawing.Size(33, 31);
            this.imgShoppingCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgShoppingCart.TabIndex = 3;
            this.imgShoppingCart.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnPay.Location = new System.Drawing.Point(697, 568);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(241, 82);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Finish and Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.BtnPay_Click);
            // 
            // btnVegetables
            // 
            this.btnVegetables.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVegetables.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnVegetables.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVegetables.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btnVegetables.Location = new System.Drawing.Point(629, 107);
            this.btnVegetables.Name = "btnVegetables";
            this.btnVegetables.Size = new System.Drawing.Size(181, 101);
            this.btnVegetables.TabIndex = 10;
            this.btnVegetables.Text = "Vegetables";
            this.btnVegetables.UseVisualStyleBackColor = false;
            this.btnVegetables.Click += new System.EventHandler(this.BtnVegetables_Click);
            // 
            // lblBasketCounter
            // 
            this.lblBasketCounter.AutoSize = true;
            this.lblBasketCounter.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBasketCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblBasketCounter.Location = new System.Drawing.Point(250, 18);
            this.lblBasketCounter.Name = "lblBasketCounter";
            this.lblBasketCounter.Size = new System.Drawing.Size(45, 25);
            this.lblBasketCounter.TabIndex = 16;
            this.lblBasketCounter.Text = "000";
            this.lblBasketCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRemoveItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnRemoveItem.Location = new System.Drawing.Point(263, 627);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(152, 90);
            this.btnRemoveItem.TabIndex = 19;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.BtnRemoveItem_Click);
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemName.Location = new System.Drawing.Point(17, 11);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(49, 25);
            this.lblItemName.TabIndex = 20;
            this.lblItemName.Text = "Item";
            // 
            // pnlBasketList
            // 
            this.pnlBasketList.AutoScroll = true;
            this.pnlBasketList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBasketList.Controls.Add(this.lblItemPrice);
            this.pnlBasketList.Controls.Add(this.lblItemName);
            this.pnlBasketList.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlBasketList.Location = new System.Drawing.Point(5, 59);
            this.pnlBasketList.Name = "pnlBasketList";
            this.pnlBasketList.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pnlBasketList.Size = new System.Drawing.Size(609, 506);
            this.pnlBasketList.TabIndex = 22;
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.AutoSize = true;
            this.lblItemPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblItemPrice.Location = new System.Drawing.Point(512, 13);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(56, 25);
            this.lblItemPrice.TabIndex = 26;
            this.lblItemPrice.Text = "Price";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalSum.Location = new System.Drawing.Point(535, 583);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(39, 25);
            this.lblTotalSum.TabIndex = 27;
            this.lblTotalSum.Text = "£ 0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(22, 583);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(12, 617);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 29;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // FormBasketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.lblBasketList);
            this.Controls.Add(this.lblBasketCounter);
            this.Controls.Add(this.imgShoppingCart);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.btnVegetables);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.pnlBasketList);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBasketList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBasketList_FormClosed);
            this.Click += new System.EventHandler(this.FormBasketList_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgShoppingCart)).EndInit();
            this.pnlBasketList.ResumeLayout(false);
            this.pnlBasketList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasketList;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.PictureBox imgShoppingCart;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnVegetables;
        private System.Windows.Forms.Label lblBasketCounter;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Panel pnlBasketList;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.PictureBox btnHelp;
    }
}