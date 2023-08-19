namespace OrderModule.UI
{
    partial class CategoryUpdateForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.Button();
            this.ProductAdded = new System.Windows.Forms.Button();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.tbxCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductList
            // 
            this.ProductList.Location = new System.Drawing.Point(96, 85);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(75, 23);
            this.ProductList.TabIndex = 41;
            this.ProductList.Text = "Geri";
            this.ProductList.UseVisualStyleBackColor = true;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // ProductAdded
            // 
            this.ProductAdded.Location = new System.Drawing.Point(177, 85);
            this.ProductAdded.Name = "ProductAdded";
            this.ProductAdded.Size = new System.Drawing.Size(75, 23);
            this.ProductAdded.TabIndex = 40;
            this.ProductAdded.Text = "Güncelle";
            this.ProductAdded.UseVisualStyleBackColor = true;
            this.ProductAdded.Click += new System.EventHandler(this.ProductAdded_Click);
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(129, 48);
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(120, 20);
            this.tbxDescription.TabIndex = 39;
            // 
            // tbxCategoryName
            // 
            this.tbxCategoryName.Location = new System.Drawing.Point(129, 11);
            this.tbxCategoryName.Name = "tbxCategoryName";
            this.tbxCategoryName.Size = new System.Drawing.Size(120, 20);
            this.tbxCategoryName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Kategori Açiklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kategori İsmi:";
            // 
            // CategoryUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 120);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.ProductAdded);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.tbxCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CategoryUpdateForm";
            this.Text = "CategoryUpdateForm";
            this.Load += new System.EventHandler(this.CategoryUpdateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProductList;
        private System.Windows.Forms.Button ProductAdded;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.TextBox tbxCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}