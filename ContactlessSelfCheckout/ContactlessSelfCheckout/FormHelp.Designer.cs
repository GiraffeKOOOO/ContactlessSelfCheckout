namespace ContactlessSelfCheckout
{
    partial class FormHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHelp));
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.imgAssistant = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAssistant)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.lblInstruction.Location = new System.Drawing.Point(44, 42);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(931, 51);
            this.lblInstruction.TabIndex = 8;
            this.lblInstruction.Text = "Please wait an assistant will come and help you";
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ContactlessSelfCheckout.Properties.Resources.back_button;
            this.btnBack.Location = new System.Drawing.Point(307, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(395, 81);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 10;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            // 
            // imgAssistant
            // 
            this.imgAssistant.Image = global::ContactlessSelfCheckout.Properties.Resources.help_background;
            this.imgAssistant.Location = new System.Drawing.Point(256, 144);
            this.imgAssistant.Name = "imgAssistant";
            this.imgAssistant.Size = new System.Drawing.Size(587, 447);
            this.imgAssistant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgAssistant.TabIndex = 9;
            this.imgAssistant.TabStop = false;
            this.imgAssistant.Click += new System.EventHandler(this.ImgAssistant_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(132)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lblInstruction);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 124);
            this.panel1.TabIndex = 11;
            // 
            // FormHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.imgAssistant);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.FormHelp_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAssistant)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.PictureBox imgAssistant;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.Panel panel1;
    }
}