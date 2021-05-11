
namespace ContactlessSelfCheckout
{
    partial class FormEnding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEnding));
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.imgOrangeCircle = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgOrangeCircle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F);
            this.lblFormTitle.Location = new System.Drawing.Point(300, 280);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(409, 91);
            this.lblFormTitle.TabIndex = 28;
            this.lblFormTitle.Text = "Thank you";
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblInstruction.Location = new System.Drawing.Point(259, 380);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(490, 46);
            this.lblInstruction.TabIndex = 34;
            this.lblInstruction.Text = "Please take your shopping";
            // 
            // imgOrangeCircle
            // 
            this.imgOrangeCircle.Image = global::ContactlessSelfCheckout.Properties.Resources.orange_circle;
            this.imgOrangeCircle.Location = new System.Drawing.Point(214, 74);
            this.imgOrangeCircle.Name = "imgOrangeCircle";
            this.imgOrangeCircle.Size = new System.Drawing.Size(580, 580);
            this.imgOrangeCircle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOrangeCircle.TabIndex = 38;
            this.imgOrangeCircle.TabStop = false;
            this.imgOrangeCircle.Click += new System.EventHandler(this.ImgOrangeCircle_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 37;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // FormEnding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.imgOrangeCircle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEnding";
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEnding_FormClosed);
            this.Shown += new System.EventHandler(this.FormEnding_Shown);
            this.Click += new System.EventHandler(this.FormEnding_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgOrangeCircle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox imgOrangeCircle;
    }
}