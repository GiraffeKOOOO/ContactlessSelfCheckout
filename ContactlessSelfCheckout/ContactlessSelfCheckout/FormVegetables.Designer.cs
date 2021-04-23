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
            this.lblAlphabetTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlVegetableItems = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.db_ProductsDataSet = new ContactlessSelfCheckout.Db_ProductsDataSet();
            this.dbProductsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProductTableAdapter = new ContactlessSelfCheckout.Db_ProductsDataSetTableAdapters.Table_ProductTableAdapter();
            this.pnlAlphabet = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.db_ProductsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).BeginInit();
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
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnHelp.Location = new System.Drawing.Point(12, 627);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(118, 90);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
            // 
            // pnlVegetableItems
            // 
            this.pnlVegetableItems.Location = new System.Drawing.Point(12, 109);
            this.pnlVegetableItems.Name = "pnlVegetableItems";
            this.pnlVegetableItems.Size = new System.Drawing.Size(984, 502);
            this.pnlVegetableItems.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnBack.Location = new System.Drawing.Point(430, 627);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 90);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            // 
            // FormVegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlAlphabet);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlVegetableItems);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAlphabetTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVegetables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contactless Self-Checkout";
            this.Load += new System.EventHandler(this.FormVegetables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.db_ProductsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAlphabetTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlVegetableItems;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource dbProductsDataSetBindingSource;
        private Db_ProductsDataSet db_ProductsDataSet;
        private System.Windows.Forms.BindingSource tableProductBindingSource;
        private Db_ProductsDataSetTableAdapters.Table_ProductTableAdapter table_ProductTableAdapter;
        private System.Windows.Forms.Panel pnlAlphabet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}