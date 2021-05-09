namespace ContactlessSelfCheckout
{
    partial class FormStartScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStartScreen));
            this.lblScreenTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.lblAppName2 = new System.Windows.Forms.Label();
            this.lblAppName1 = new System.Windows.Forms.Label();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            this.btnOwnBag = new System.Windows.Forms.PictureBox();
            this.imgCart = new System.Windows.Forms.PictureBox();
            this.imgHandWave = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.PictureBox();
            this.pnlBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOwnBag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHandWave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.AutoSize = true;
            this.lblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.lblScreenTitle.Location = new System.Drawing.Point(621, 84);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(219, 91);
            this.lblScreenTitle.TabIndex = 0;
            this.lblScreenTitle.Text = "Hello";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction.Location = new System.Drawing.Point(604, 224);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(257, 31);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please scan an item";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.pnlBackground.Controls.Add(this.lblAppName2);
            this.pnlBackground.Controls.Add(this.lblAppName1);
            this.pnlBackground.Controls.Add(this.imgCart);
            this.pnlBackground.Controls.Add(this.imgHandWave);
            this.pnlBackground.Controls.Add(this.btnHelp);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlBackground.ForeColor = System.Drawing.Color.White;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(467, 729);
            this.pnlBackground.TabIndex = 6;
            // 
            // lblAppName2
            // 
            this.lblAppName2.AutoSize = true;
            this.lblAppName2.Font = new System.Drawing.Font("Century Gothic", 40F);
            this.lblAppName2.ForeColor = System.Drawing.Color.Black;
            this.lblAppName2.Location = new System.Drawing.Point(34, 409);
            this.lblAppName2.Name = "lblAppName2";
            this.lblAppName2.Size = new System.Drawing.Size(397, 65);
            this.lblAppName2.TabIndex = 4;
            this.lblAppName2.Text = "Self-Checkout";
            // 
            // lblAppName1
            // 
            this.lblAppName1.AutoSize = true;
            this.lblAppName1.Font = new System.Drawing.Font("Century Gothic", 50F);
            this.lblAppName1.ForeColor = System.Drawing.Color.Black;
            this.lblAppName1.Location = new System.Drawing.Point(20, 326);
            this.lblAppName1.Name = "lblAppName1";
            this.lblAppName1.Size = new System.Drawing.Size(418, 81);
            this.lblAppName1.TabIndex = 3;
            this.lblAppName1.Text = "Contactless";
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions2.Location = new System.Drawing.Point(534, 266);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(404, 31);
            this.lblInstructions2.TabIndex = 7;
            this.lblInstructions2.Text = "or press the start button to begin";
            // 
            // btnOwnBag
            // 
            this.btnOwnBag.Image = global::ContactlessSelfCheckout.Properties.Resources.own_bag_button;
            this.btnOwnBag.Location = new System.Drawing.Point(540, 564);
            this.btnOwnBag.Name = "btnOwnBag";
            this.btnOwnBag.Size = new System.Drawing.Size(395, 81);
            this.btnOwnBag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOwnBag.TabIndex = 5;
            this.btnOwnBag.TabStop = false;
            this.btnOwnBag.Click += new System.EventHandler(this.BtnOwnBag_Click);
            this.btnOwnBag.MouseEnter += new System.EventHandler(this.BtnOwnBag_MouseEnter);
            this.btnOwnBag.MouseLeave += new System.EventHandler(this.BtnOwnBag_MouseLeave);
            // 
            // imgCart
            // 
            this.imgCart.Image = ((System.Drawing.Image)(resources.GetObject("imgCart.Image")));
            this.imgCart.Location = new System.Drawing.Point(247, 120);
            this.imgCart.Name = "imgCart";
            this.imgCart.Size = new System.Drawing.Size(197, 177);
            this.imgCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCart.TabIndex = 2;
            this.imgCart.TabStop = false;
            // 
            // imgHandWave
            // 
            this.imgHandWave.Image = ((System.Drawing.Image)(resources.GetObject("imgHandWave.Image")));
            this.imgHandWave.Location = new System.Drawing.Point(21, 120);
            this.imgHandWave.Name = "imgHandWave";
            this.imgHandWave.Size = new System.Drawing.Size(197, 177);
            this.imgHandWave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgHandWave.TabIndex = 1;
            this.imgHandWave.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 0;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // btnStart
            // 
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(540, 393);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(395, 81);
            this.btnStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStart.TabIndex = 5;
            this.btnStart.TabStop = false;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.BtnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.BtnStart_MouseLeave);
            // 
            // FormStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.btnOwnBag);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblScreenTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-checkout";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStartScreen_FormClosed);
            this.Click += new System.EventHandler(this.FormStartScreen_Click);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnOwnBag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHandWave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox btnStart;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnOwnBag;
        private System.Windows.Forms.Label lblInstructions2;
        private System.Windows.Forms.Label lblAppName2;
        private System.Windows.Forms.Label lblAppName1;
        private System.Windows.Forms.PictureBox imgCart;
        private System.Windows.Forms.PictureBox imgHandWave;
    }
}

