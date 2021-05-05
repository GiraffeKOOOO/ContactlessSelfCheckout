
namespace ContactlessSelfCheckout
{
    partial class FormPay
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.imgTitleBorder = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.imgTotalBorder = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.btnCoupon = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblToPay = new System.Windows.Forms.Label();
            this.lblToPaySum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFormTitle.Location = new System.Drawing.Point(433, 44);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(141, 25);
            this.lblFormTitle.TabIndex = 27;
            this.lblFormTitle.Text = "Finish and Pay";
            // 
            // imgTitleBorder
            // 
            this.imgTitleBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitleBorder.Location = new System.Drawing.Point(420, 36);
            this.imgTitleBorder.Name = "imgTitleBorder";
            this.imgTitleBorder.Size = new System.Drawing.Size(169, 43);
            this.imgTitleBorder.TabIndex = 28;
            this.imgTitleBorder.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotal.Location = new System.Drawing.Point(219, 110);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalSum.Location = new System.Drawing.Point(732, 110);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(39, 25);
            this.lblTotalSum.TabIndex = 30;
            this.lblTotalSum.Text = "£ 0";
            // 
            // imgTotalBorder
            // 
            this.imgTotalBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTotalBorder.Location = new System.Drawing.Point(206, 98);
            this.imgTotalBorder.Name = "imgTotalBorder";
            this.imgTotalBorder.Size = new System.Drawing.Size(605, 50);
            this.imgTotalBorder.TabIndex = 32;
            this.imgTotalBorder.TabStop = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblInstruction.Location = new System.Drawing.Point(319, 254);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(368, 29);
            this.lblInstruction.TabIndex = 33;
            this.lblInstruction.Text = "Please select method of payment";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHelp.Location = new System.Drawing.Point(12, 627);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(118, 90);
            this.btnHelp.TabIndex = 34;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnCash
            // 
            this.btnCash.Location = new System.Drawing.Point(88, 347);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(218, 142);
            this.btnCash.TabIndex = 35;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = true;
            this.btnCash.Click += new System.EventHandler(this.BtnCash_Click);
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(402, 347);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(218, 142);
            this.btnCard.TabIndex = 36;
            this.btnCard.Text = "Visa/Credit Card";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.BtnCard_Click);
            // 
            // btnCoupon
            // 
            this.btnCoupon.Location = new System.Drawing.Point(702, 347);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(218, 142);
            this.btnCoupon.TabIndex = 37;
            this.btnCoupon.Text = "Coupon";
            this.btnCoupon.UseVisualStyleBackColor = true;
            this.btnCoupon.Click += new System.EventHandler(this.BtnCoupon_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBack.Location = new System.Drawing.Point(430, 627);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 90);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // lblToPay
            // 
            this.lblToPay.AutoSize = true;
            this.lblToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblToPay.Location = new System.Drawing.Point(219, 189);
            this.lblToPay.Name = "lblToPay";
            this.lblToPay.Size = new System.Drawing.Size(102, 25);
            this.lblToPay.TabIndex = 40;
            this.lblToPay.Text = "Left to pay";
            // 
            // lblToPaySum
            // 
            this.lblToPaySum.AutoSize = true;
            this.lblToPaySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblToPaySum.Location = new System.Drawing.Point(732, 189);
            this.lblToPaySum.Name = "lblToPaySum";
            this.lblToPaySum.Size = new System.Drawing.Size(39, 25);
            this.lblToPaySum.TabIndex = 39;
            this.lblToPaySum.Text = "£ 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(206, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(605, 50);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblToPay);
            this.Controls.Add(this.lblToPaySum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCoupon);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.imgTotalBorder);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.imgTitleBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPay_FormClosed);
            this.Load += new System.EventHandler(this.FormPay_Load);
            this.Click += new System.EventHandler(this.FormPay_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox imgTitleBorder;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.PictureBox imgTotalBorder;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.Button btnCoupon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblToPay;
        private System.Windows.Forms.Label lblToPaySum;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}