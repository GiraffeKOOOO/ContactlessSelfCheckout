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
            this.lblScreenTitle = new System.Windows.Forms.Label();
            this.lblInstruction = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnOwnBag = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScreenTitle
            // 
            this.lblScreenTitle.AutoSize = true;
            this.lblScreenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenTitle.Location = new System.Drawing.Point(415, 60);
            this.lblScreenTitle.Name = "lblScreenTitle";
            this.lblScreenTitle.Size = new System.Drawing.Size(178, 73);
            this.lblScreenTitle.TabIndex = 0;
            this.lblScreenTitle.Text = "Hello";
            this.lblScreenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblInstruction.Location = new System.Drawing.Point(177, 176);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(654, 31);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Text = "Please scan an item or press the start button to begin";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.btnStart.Location = new System.Drawing.Point(351, 298);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(306, 90);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // btnOwnBag
            // 
            this.btnOwnBag.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOwnBag.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOwnBag.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnOwnBag.Location = new System.Drawing.Point(351, 416);
            this.btnOwnBag.Name = "btnOwnBag";
            this.btnOwnBag.Size = new System.Drawing.Size(306, 90);
            this.btnOwnBag.TabIndex = 3;
            this.btnOwnBag.Text = "I have my own bag";
            this.btnOwnBag.UseVisualStyleBackColor = false;
            this.btnOwnBag.Click += new System.EventHandler(this.OwnBagButton_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHelp.Location = new System.Drawing.Point(23, 627);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(118, 90);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // FormStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnOwnBag);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblInstruction);
            this.Controls.Add(this.lblScreenTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-checkout";
            this.TopMost = true;
            this.Click += new System.EventHandler(this.FormStartScreen_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScreenTitle;
        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnOwnBag;
        private System.Windows.Forms.Button btnHelp;
    }
}

