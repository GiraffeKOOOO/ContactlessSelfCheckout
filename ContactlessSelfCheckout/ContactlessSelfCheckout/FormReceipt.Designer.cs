
namespace ContactlessSelfCheckout
{
    partial class FormReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReceipt));
            this.lbFormTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnYes = new System.Windows.Forms.PictureBox();
            this.btnNo = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormTitle
            // 
            this.lbFormTitle.AutoSize = true;
            this.lbFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lbFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.lbFormTitle.Location = new System.Drawing.Point(122, 51);
            this.lbFormTitle.Name = "lbFormTitle";
            this.lbFormTitle.Size = new System.Drawing.Size(774, 76);
            this.lbFormTitle.TabIndex = 32;
            this.lbFormTitle.Text = "Would you like a receipt?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbFormTitle);
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 192);
            this.panel1.TabIndex = 46;
            // 
            // btnYes
            // 
            this.btnYes.Image = global::ContactlessSelfCheckout.Properties.Resources.yes_button;
            this.btnYes.Location = new System.Drawing.Point(556, 390);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(395, 81);
            this.btnYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYes.TabIndex = 49;
            this.btnYes.TabStop = false;
            this.btnYes.Click += new System.EventHandler(this.BtnYes_Click);
            this.btnYes.MouseEnter += new System.EventHandler(this.BtnYes_MouseEnter);
            this.btnYes.MouseLeave += new System.EventHandler(this.BtnYes_MouseLeave);
            // 
            // btnNo
            // 
            this.btnNo.Image = global::ContactlessSelfCheckout.Properties.Resources.no_button;
            this.btnNo.Location = new System.Drawing.Point(57, 390);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(395, 81);
            this.btnNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNo.TabIndex = 48;
            this.btnNo.TabStop = false;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            this.btnNo.MouseEnter += new System.EventHandler(this.BtnNo_MouseEnter);
            this.btnNo.MouseLeave += new System.EventHandler(this.BtnNo_MouseLeave);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 47;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // FormReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReceipt";
            this.Text = "Contactless Self-checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReceipt_FormClosed);
            this.Click += new System.EventHandler(this.FormReceipt_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbFormTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnNo;
        private System.Windows.Forms.PictureBox btnYes;
    }
}