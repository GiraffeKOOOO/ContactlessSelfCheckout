
namespace ContactlessSelfCheckout
{
    partial class FormPaymentMethod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaymentMethod));
            this.lblInstruction = new System.Windows.Forms.Label();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.imgPaymentType = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaymentType)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction.Location = new System.Drawing.Point(288, 108);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(414, 31);
            this.lblInstruction.TabIndex = 34;
            this.lblInstruction.Text = "Please select method of payment";
            // 
            // imgLoading
            // 
            this.imgLoading.Image = ((System.Drawing.Image)(resources.GetObject("imgLoading.Image")));
            this.imgLoading.Location = new System.Drawing.Point(584, 236);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(311, 317);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 40;
            this.imgLoading.TabStop = false;
            // 
            // imgPaymentType
            // 
            this.imgPaymentType.Location = new System.Drawing.Point(136, 236);
            this.imgPaymentType.Name = "imgPaymentType";
            this.imgPaymentType.Size = new System.Drawing.Size(311, 317);
            this.imgPaymentType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaymentType.TabIndex = 41;
            this.imgPaymentType.TabStop = false;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnDone.Location = new System.Drawing.Point(847, 627);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(149, 90);
            this.btnDone.TabIndex = 42;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.BtnDone_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblFormTitle);
            this.panel1.Controls.Add(this.lblInstruction);
            this.panel1.Location = new System.Drawing.Point(-7, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 192);
            this.panel1.TabIndex = 45;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lblFormTitle.Location = new System.Drawing.Point(239, 17);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(541, 76);
            this.lblFormTitle.TabIndex = 32;
            this.lblFormTitle.Text = "Coupon payment";
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 46;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ContactlessSelfCheckout.Properties.Resources.back_button;
            this.btnBack.Location = new System.Drawing.Point(307, 627);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(395, 81);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 47;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            // 
            // FormPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.imgPaymentType);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPaymentMethod_FormClosed);
            this.Click += new System.EventHandler(this.FormPaymentMethod_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaymentType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.PictureBox imgPaymentType;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Label lblFormTitle;
    }
}