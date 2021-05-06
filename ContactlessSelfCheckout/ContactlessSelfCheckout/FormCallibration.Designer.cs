namespace ContactlessSelfCheckout
{
    partial class FormCallibration
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
            this.lblScreenTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.imgCameraDisplay = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.lblInstructions2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraDisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.AutoSize = true;
            this.lblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenTitle.Location = new System.Drawing.Point(415, 9);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(178, 73);
            this.lblScreenTitle.TabIndex = 1;
            this.lblScreenTitle.Text = "Hello";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction.Location = new System.Drawing.Point(62, 99);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(884, 31);
            this.lblInstruction.TabIndex = 2;
            this.lblInstruction.Text = "Please stand in the outlined area and wave until the cursor starts moving";
            // 
            // imgCameraDisplay
            // 
            this.imgCameraDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgCameraDisplay.Location = new System.Drawing.Point(222, 201);
            this.imgCameraDisplay.Name = "imgCameraDisplay";
            this.imgCameraDisplay.Size = new System.Drawing.Size(565, 399);
            this.imgCameraDisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCameraDisplay.TabIndex = 6;
            this.imgCameraDisplay.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(12, 617);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 7;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // lblInstructions2
            // 
            this.lblInstructions2.AutoSize = true;
            this.lblInstructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstructions2.Location = new System.Drawing.Point(177, 142);
            this.lblInstructions2.Name = "lblInstructions2";
            this.lblInstructions2.Size = new System.Drawing.Size(655, 31);
            this.lblInstructions2.TabIndex = 8;
            this.lblInstructions2.Text = "When you\'re ready click the start button to get started";
            // 
            // FormCallibration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.lblInstructions2);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.imgCameraDisplay);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblScreenTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCallibration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCallibration_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraDisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox imgCameraDisplay;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.Label lblInstructions2;
    }
}