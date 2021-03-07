namespace ContactlessSelfCheckout
{
    partial class IndexForm
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
            this.screenTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // screenTitle
            // 
            this.screenTitle.AutoSize = true;
            this.screenTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenTitle.Location = new System.Drawing.Point(415, 24);
            this.screenTitle.Name = "screenTitle";
            this.screenTitle.Size = new System.Drawing.Size(178, 73);
            this.screenTitle.TabIndex = 0;
            this.screenTitle.Text = "Hello";
            this.screenTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.screenTitle);
            this.Name = "IndexForm";
            this.Text = "Contactless Self-checkout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label screenTitle;
    }
}

