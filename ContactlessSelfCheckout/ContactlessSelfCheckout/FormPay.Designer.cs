
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
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBorder)).BeginInit();
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
            this.lblTotal.Location = new System.Drawing.Point(215, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 25);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTotalSum.Location = new System.Drawing.Point(728, 143);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(39, 25);
            this.lblTotalSum.TabIndex = 30;
            this.lblTotalSum.Text = "£ 0";
            // 
            // imgTotalBorder
            // 
            this.imgTotalBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTotalBorder.Location = new System.Drawing.Point(202, 131);
            this.imgTotalBorder.Name = "imgTotalBorder";
            this.imgTotalBorder.Size = new System.Drawing.Size(605, 50);
            this.imgTotalBorder.TabIndex = 32;
            this.imgTotalBorder.TabStop = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblInstruction.Location = new System.Drawing.Point(320, 230);
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
            // 
            // btnCard
            // 
            this.btnCard.Location = new System.Drawing.Point(402, 347);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(218, 142);
            this.btnCard.TabIndex = 36;
            this.btnCard.Text = "Visa/Credit Card";
            this.btnCard.UseVisualStyleBackColor = true;
            // 
            // btnCoupon
            // 
            this.btnCoupon.Location = new System.Drawing.Point(702, 347);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(218, 142);
            this.btnCoupon.TabIndex = 37;
            this.btnCoupon.Text = "Coupon";
            this.btnCoupon.UseVisualStyleBackColor = true;
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
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
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
            this.Load += new System.EventHandler(this.FormPay_Load);
            this.Click += new System.EventHandler(this.FormPay_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTotalBorder)).EndInit();
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
    }
}