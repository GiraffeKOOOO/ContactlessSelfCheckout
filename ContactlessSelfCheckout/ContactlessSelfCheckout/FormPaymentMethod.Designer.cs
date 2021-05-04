
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
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.imgTitleBorder = new System.Windows.Forms.PictureBox();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.imgLoading = new System.Windows.Forms.PictureBox();
            this.imgPaymentType = new System.Windows.Forms.PictureBox();
            this.btnDone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaymentType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblFormTitle.Location = new System.Drawing.Point(422, 20);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(164, 25);
            this.lblFormTitle.TabIndex = 29;
            this.lblFormTitle.Text = "Coupon Payment";
            // 
            // imgTitleBorder
            // 
            this.imgTitleBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTitleBorder.Location = new System.Drawing.Point(372, 12);
            this.imgTitleBorder.Name = "imgTitleBorder";
            this.imgTitleBorder.Size = new System.Drawing.Size(264, 43);
            this.imgTitleBorder.TabIndex = 30;
            this.imgTitleBorder.TabStop = false;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.lblInstruction.Location = new System.Drawing.Point(320, 77);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(368, 29);
            this.lblInstruction.TabIndex = 34;
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
            this.btnHelp.TabIndex = 35;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBack.Location = new System.Drawing.Point(430, 627);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 90);
            this.btnBack.TabIndex = 39;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // imgLoading
            // 
            this.imgLoading.Image = ((System.Drawing.Image)(resources.GetObject("imgLoading.Image")));
            this.imgLoading.Location = new System.Drawing.Point(573, 197);
            this.imgLoading.Name = "imgLoading";
            this.imgLoading.Size = new System.Drawing.Size(311, 317);
            this.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoading.TabIndex = 40;
            this.imgLoading.TabStop = false;
            // 
            // imgPaymentType
            // 
            this.imgPaymentType.Location = new System.Drawing.Point(184, 197);
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
            // FormPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.imgPaymentType);
            this.Controls.Add(this.imgLoading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.imgTitleBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.imgTitleBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaymentType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox imgTitleBorder;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox imgLoading;
        private System.Windows.Forms.PictureBox imgPaymentType;
        private System.Windows.Forms.Button btnDone;
    }
}