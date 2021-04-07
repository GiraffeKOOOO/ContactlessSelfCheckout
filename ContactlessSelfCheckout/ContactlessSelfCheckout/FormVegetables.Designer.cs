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
            this.lblAlphabetSearch = new System.Windows.Forms.Label();
            this.lblAlphabetTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlVegetableItems = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.db_ProductsDataSet = new ContactlessSelfCheckout.Db_ProductsDataSet();
            this.dbProductsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_ProductTableAdapter = new ContactlessSelfCheckout.Db_ProductsDataSetTableAdapters.Table_ProductTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.db_ProductsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbProductsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlphabetSearch
            // 
            this.lblAlphabetSearch.AutoSize = true;
            this.lblAlphabetSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAlphabetSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlphabetSearch.Location = new System.Drawing.Point(17, 42);
            this.lblAlphabetSearch.Name = "lblAlphabetSearch";
            this.lblAlphabetSearch.Size = new System.Drawing.Size(975, 33);
            this.lblAlphabetSearch.TabIndex = 0;
            this.lblAlphabetSearch.Text = "A   B   C   D   E   F   G   H   I   J   K   L   M   N   O   P   Q   R   S   T   U" +
    "   V   X   Y   Z";
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
            // FormVegetables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlVegetableItems);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblAlphabetTitle);
            this.Controls.Add(this.lblAlphabetSearch);
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

        private System.Windows.Forms.Label lblAlphabetSearch;
        private System.Windows.Forms.Label lblAlphabetTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel pnlVegetableItems;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource dbProductsDataSetBindingSource;
        private Db_ProductsDataSet db_ProductsDataSet;
        private System.Windows.Forms.BindingSource tableProductBindingSource;
        private Db_ProductsDataSetTableAdapters.Table_ProductTableAdapter table_ProductTableAdapter;
    }
}