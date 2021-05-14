namespace ContactlessSelfCheckout
{
    partial class FormVegetables
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVegetables));
            this.lblAlphabetTitle = new System.Windows.Forms.Label();
            this.pnlVegetableItems = new System.Windows.Forms.Panel();
            this.db_ProductsDataSet = new ContactlessSelfCheckout.Db_ProductsDataSet();
            this.dbProductsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProductTableAdapter = new ContactlessSelfCheckout.Db_ProductsDataSetTableAdapters.Table_ProductTableAdapter();
            this.pnlAlphabet = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHelp = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.db_ProductsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlphabetTitle
            // 
            this.lblAlphabetTitle.AutoSize = true;
            this.lblAlphabetTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblAlphabetTitle.Location = new System.Drawing.Point(432, 9);
            this.lblAlphabetTitle.Name = "lblAlphabetTitle";
            this.lblAlphabetTitle.Size = new System.Drawing.Size(154, 25);
            this.lblAlphabetTitle.TabIndex = 1;
            this.lblAlphabetTitle.Text = "Alphabet search";
            // 
            // pnlVegetableItems
            // 
            this.pnlVegetableItems.Location = new System.Drawing.Point(12, 109);
            this.pnlVegetableItems.Name = "pnlVegetableItems";
            this.pnlVegetableItems.Size = new System.Drawing.Size(984, 502);
            this.pnlVegetableItems.TabIndex = 8;
            // 
            // db_ProductsDataSet
            // 
            this.db_ProductsDataSet.DataSetName = "Db_ProductsDataSet";
            this.db_ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbProductsDataSetBindingSource
            // 
            this.dbProductsDataSetBindingSource.DataSource = this.db_ProductsDataSet;
            this.dbProductsDataSetBindingSource.Position = 0;
            // 
            // tableProductBindingSource
            // 
            this.tableProductBindingSource.DataMember = "Table_Product";
            this.tableProductBindingSource.DataSource = this.dbProductsDataSetBindingSource;
            // 
            // table_ProductTableAdapter
            // 
            this.table_ProductTableAdapter.ClearBeforeFill = true;
            // 
            // pnlAlphabet
            // 
            this.pnlAlphabet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAlphabet.Location = new System.Drawing.Point(3, 37);
            this.pnlAlphabet.Name = "pnlAlphabet";
            this.pnlAlphabet.Size = new System.Drawing.Size(1001, 52);
            this.pnlAlphabet.TabIndex = 10;
            // 
            // btnHelp
            // 
            this.btnHelp.Image = global::ContactlessSelfCheckout.Properties.Resources.help_button;
            this.btnHelp.Location = new System.Drawing.Point(7, 622);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(100, 100);
            this.btnHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHelp.TabIndex = 43;
            this.btnHelp.TabStop = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            this.btnHelp.MouseEnter += new System.EventHandler(this.BtnHelp_MouseEnter);
            this.btnHelp.MouseLeave += new System.EventHandler(this.BtnHelp_MouseLeave);
            // 
            // btnBack
            // 
            this.btnBack.Image = global::ContactlessSelfCheckout.Properties.Resources.back_button;
            this.btnBack.Location = new System.Drawing.Point(307, 636);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(395, 81);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 44;
            this.btnBack.TabStop = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            this.btnBack.MouseEnter += new System.EventHandler(this.BtnBack_MouseEnter);
            this.btnBack.MouseLeave += new System.EventHandler(this.BtnBack_MouseLeave);
            // 
            // FormVegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlAlphabet);
            this.Controls.Add(this.pnlVegetableItems);
            this.Controls.Add(this.lblAlphabetTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVegetables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVegetables_FormClosed);
            this.Load += new System.EventHandler(this.FormVegetables_Load);
            this.Click += new System.EventHandler(this.FormVegetables_Click);
            ((System.ComponentModel.ISupportInitialize)(this.db_ProductsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlphabetTitle;
        private System.Windows.Forms.Panel pnlVegetableItems;
        private System.Windows.Forms.BindingSource dbProductsDataSetBindingSource;
        private Db_ProductsDataSet db_ProductsDataSet;
        private System.Windows.Forms.BindingSource tableProductBindingSource;
        private Db_ProductsDataSetTableAdapters.Table_ProductTableAdapter table_ProductTableAdapter;
        private System.Windows.Forms.Panel pnlAlphabet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox btnHelp;
        private System.Windows.Forms.PictureBox btnBack;
    }
}