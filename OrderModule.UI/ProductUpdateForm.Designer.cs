namespace OrderModule.UI
{
    partial class ProductUpdateForm
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
            this.SupplierAdd = new System.Windows.Forms.Button();
            this.CategoryAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nmrUnitInStock = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.Button();
            this.ProductUpdated = new System.Windows.Forms.Button();
            this.cbxDicontinued = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitInStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // SupplierAdd
            // 
            this.SupplierAdd.Location = new System.Drawing.Point(284, 54);
            this.SupplierAdd.Name = "SupplierAdd";
            this.SupplierAdd.Size = new System.Drawing.Size(27, 24);
            this.SupplierAdd.TabIndex = 37;
            this.SupplierAdd.Text = "+";
            this.SupplierAdd.UseVisualStyleBackColor = true;
            this.SupplierAdd.Click += new System.EventHandler(this.SupplierAdd_Click);
            // 
            // CategoryAdd
            // 
            this.CategoryAdd.Location = new System.Drawing.Point(284, 92);
            this.CategoryAdd.Name = "CategoryAdd";
            this.CategoryAdd.Size = new System.Drawing.Size(27, 24);
            this.CategoryAdd.TabIndex = 36;
            this.CategoryAdd.Text = "+";
            this.CategoryAdd.UseVisualStyleBackColor = true;
            this.CategoryAdd.Click += new System.EventHandler(this.CategoryAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Stok Miktari";
            // 
            // nmrUnitInStock
            // 
            this.nmrUnitInStock.Location = new System.Drawing.Point(132, 221);
            this.nmrUnitInStock.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrUnitInStock.Name = "nmrUnitInStock";
            this.nmrUnitInStock.Size = new System.Drawing.Size(180, 20);
            this.nmrUnitInStock.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductList
            // 
            this.ProductList.Location = new System.Drawing.Point(132, 293);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(75, 23);
            this.ProductList.TabIndex = 32;
            this.ProductList.Text = "Geri";
            this.ProductList.UseVisualStyleBackColor = true;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // ProductUpdated
            // 
            this.ProductUpdated.Location = new System.Drawing.Point(236, 293);
            this.ProductUpdated.Name = "ProductUpdated";
            this.ProductUpdated.Size = new System.Drawing.Size(75, 23);
            this.ProductUpdated.TabIndex = 31;
            this.ProductUpdated.Text = "Güncelle";
            this.ProductUpdated.UseVisualStyleBackColor = true;
            this.ProductUpdated.Click += new System.EventHandler(this.ProductUpdated_Click);
            // 
            // cbxDicontinued
            // 
            this.cbxDicontinued.FormattingEnabled = true;
            this.cbxDicontinued.Location = new System.Drawing.Point(132, 257);
            this.cbxDicontinued.Name = "cbxDicontinued";
            this.cbxDicontinued.Size = new System.Drawing.Size(179, 21);
            this.cbxDicontinued.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Aktif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Fiyat";
            // 
            // nmrUnitPrice
            // 
            this.nmrUnitPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmrUnitPrice.Location = new System.Drawing.Point(132, 186);
            this.nmrUnitPrice.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmrUnitPrice.Name = "nmrUnitPrice";
            this.nmrUnitPrice.Size = new System.Drawing.Size(179, 20);
            this.nmrUnitPrice.TabIndex = 27;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(132, 146);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(179, 20);
            this.tbxQuantityPerUnit.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Birim Başına Miktar";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(132, 95);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(146, 21);
            this.cbxCategory.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Kategory:";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(132, 57);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(146, 21);
            this.cbxSupplier.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tedarikçi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ürün Adı:";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(132, 28);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(179, 20);
            this.tbxProductName.TabIndex = 19;
            // 
            // ProductUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 338);
            this.Controls.Add(this.SupplierAdd);
            this.Controls.Add(this.CategoryAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmrUnitInStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.ProductUpdated);
            this.Controls.Add(this.cbxDicontinued);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nmrUnitPrice);
            this.Controls.Add(this.tbxQuantityPerUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxSupplier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxProductName);
            this.Name = "ProductUpdateForm";
            this.Text = "ProductUpdateForm";
            this.Load += new System.EventHandler(this.ProductUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitInStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SupplierAdd;
        private System.Windows.Forms.Button CategoryAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmrUnitInStock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProductList;
        private System.Windows.Forms.Button ProductUpdated;
        private System.Windows.Forms.ComboBox cbxDicontinued;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nmrUnitPrice;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxProductName;
    }
}