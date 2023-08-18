namespace OrderModule.UI
{
    partial class ProductListForm
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.ProductUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(18, 51);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(894, 387);
            this.dgwProduct.TabIndex = 0;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(791, 11);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(602, 12);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(129, 20);
            this.tbxProductName.TabIndex = 2;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Location = new System.Drawing.Point(99, 12);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(60, 23);
            this.ProductAdd.TabIndex = 3;
            this.ProductAdd.Text = "EKLE";
            this.ProductAdd.UseVisualStyleBackColor = true;
            this.ProductAdd.Click += new System.EventHandler(this.ProductAdd_Click);
            // 
            // ProductUpdate
            // 
            this.ProductUpdate.Location = new System.Drawing.Point(165, 12);
            this.ProductUpdate.Name = "ProductUpdate";
            this.ProductUpdate.Size = new System.Drawing.Size(93, 23);
            this.ProductUpdate.TabIndex = 4;
            this.ProductUpdate.Text = "Güncelle";
            this.ProductUpdate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "MENÜ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductUpdate);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "ProductListForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.Button ProductUpdate;
        private System.Windows.Forms.Button button1;
    }
}

