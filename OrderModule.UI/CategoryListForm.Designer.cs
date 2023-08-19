namespace OrderModule.UI
{
    partial class CategoryListForm
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductUpdate = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(48, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "MENÜ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductUpdate
            // 
            this.ProductUpdate.Location = new System.Drawing.Point(159, 12);
            this.ProductUpdate.Name = "ProductUpdate";
            this.ProductUpdate.Size = new System.Drawing.Size(81, 23);
            this.ProductUpdate.TabIndex = 18;
            this.ProductUpdate.Text = "Güncelle";
            this.ProductUpdate.UseVisualStyleBackColor = true;
            // 
            // ProductAdd
            // 
            this.ProductAdd.Location = new System.Drawing.Point(93, 12);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(48, 23);
            this.ProductAdd.TabIndex = 17;
            this.ProductAdd.Text = "EKLE";
            this.ProductAdd.UseVisualStyleBackColor = true;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(624, 11);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(117, 20);
            this.tbxProductName.TabIndex = 16;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(785, 11);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(109, 21);
            this.cbxCategory.TabIndex = 15;
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 51);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(882, 387);
            this.dgwProduct.TabIndex = 14;
            // 
            // CategoryListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductUpdate);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "CategoryListForm";
            this.Text = "CategoryListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProductUpdate;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.DataGridView dgwProduct;
    }
}