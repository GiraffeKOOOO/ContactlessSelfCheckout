
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPay));
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalSum = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlTitleBackground = new System.Windows.Forms.Panel();
            this.btnCoupon = new System.Windows.Forms.PictureBox();
            this.btnCard = new System.Windows.Forms.PictureBox();
            this.btnCash = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCoupon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblTotal.Location = new System.Drawing.Point(414, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(181, 76);
            this.lblTotal.TabIndex = 31;
            this.lblTotal.Text = "Total";
            // 
            // lblTotalSum
            // 
            this.lblTotalSum.AutoSize = true;
            this.lblTotalSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblTotalSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.lblTotalSum.Location = new System.Drawing.Point(386, 107);
            this.lblTotalSum.Name = "lblTotalSum";
            this.lblTotalSum.Size = new System.Drawing.Size(236, 63);
            this.lblTotalSum.TabIndex = 30;
            this.lblTotalSum.Text = "£ 000.00";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblInstruction.Location = new System.Drawing.Point(199, 220);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(610, 46);
            this.lblInstruction.TabIndex = 33;
            this.lblInstruction.Text = "Please select method of payment";
            // 
            // pnlTitleBackground
            // 
            this.pnlTitleBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.pnlTitleBackground.Location = new System.Drawing.Point(-1, -2);
            this.pnlTitleBackground.Name = "pnlTitleBackground";
            this.pnlTitleBackground.Size = new System.Drawing.Size(1018, 192);
            this.pnlTitleBackground.TabIndex = 44;
            // 
            // btnCoupon
            // 
            this.btnCoupon.Image = global::ContactlessSelfCheckout.Properties.Resources.coupon_button;
            this.btnCoupon.Location = new System.Drawing.Point(714, 347);
            this.btnCoupon.Name = "btnCoupon";
            this.btnCoupon.Size = new System.Drawing.Size(218, 142);
            this.btnCoupon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCoupon.TabIndex = 47;
            this.btnCoupon.TabStop = false;
            this.btnCoupon.Click += new System.EventHandler(this.BtnCoupon_Click);
            this.btnCoupon.MouseEnter += new System.EventHandler(this.BtnCoupon_MouseEnter);
            this.btnCoupon.MouseLeave += new System.EventHandler(this.BtnCoupon_MouseLeave);
            // 
            // btnCard
            // 
            this.btnCard.Image = global::ContactlessSelfCheckout.Properties.Resources.card_button;
            this.btnCard.Location = new System.Drawing.Point(404, 347);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(218, 142);
            this.btnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCard.TabIndex = 46;
            this.btnCard.TabStop = false;
            this.btnCard.Click += new System.EventHandler(this.BtnCard_Click);
            this.btnCard.MouseEnter += new System.EventHandler(this.BtnCard_MouseEnter);
            this.btnCard.MouseLeave += new System.EventHandler(this.BtnCard_MouseLeave);
            // 
            // btnCash
            // 
            this.btnCash.Image = global::ContactlessSelfCheckout.Properties.Resources.cash_button;
            this.btnCash.Location = new System.Drawing.Point(90, 347);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(218, 142);
            this.btnCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCash.TabIndex = 45;
            this.btnCash.TabStop = false;
            this.btnCash.Click += new System.EventHandler(this.BtnCash_Click);
            this.btnCash.MouseEnter += new System.EventHandler(this.BtnCash_MouseEnter);
            this.btnCash.MouseLeave += new System.EventHandler(this.BtnCash_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ContactlessSelfCheckout.Properties.Resources.back_button;
            this.btnBack.Location = new System.Drawing.Point(292, 622);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(395, 81);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 43;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 42;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // FormPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnCoupon);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnCash);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalSum);
            this.Controls.Add(this.pnlTitleBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPay_FormClosed);
            this.Load += new System.EventHandler(this.FormPay_Load);
            this.Click += new System.EventHandler(this.FormPay_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnCoupon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalSum;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel pnlTitleBackground;
        private System.Windows.Forms.PictureBox btnCash;
        private System.Windows.Forms.PictureBox btnCard;
        private System.Windows.Forms.PictureBox btnCoupon;
    }
}