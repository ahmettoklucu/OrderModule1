﻿namespace OrderModule.UI
{
    partial class CateforyAddForm
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
            this.tbxContactName = new System.Windows.Forms.TextBox();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.Button();
            this.ProductAdded = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxContactName
            // 
            this.tbxContactName.Location = new System.Drawing.Point(131, 49);
            this.tbxContactName.Name = "tbxContactName";
            this.tbxContactName.Size = new System.Drawing.Size(120, 20);
            this.tbxContactName.TabIndex = 32;
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(131, 12);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.Size = new System.Drawing.Size(120, 20);
            this.tbxCompanyName.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Kategori Açiklama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Kategori İsmi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Menü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProductList
            // 
            this.ProductList.Location = new System.Drawing.Point(98, 86);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(75, 23);
            this.ProductList.TabIndex = 34;
            this.ProductList.Text = "Geri";
            this.ProductList.UseVisualStyleBackColor = true;
            this.ProductList.Click += new System.EventHandler(this.ProductList_Click);
            // 
            // ProductAdded
            // 
            this.ProductAdded.Location = new System.Drawing.Point(179, 86);
            this.ProductAdded.Name = "ProductAdded";
            this.ProductAdded.Size = new System.Drawing.Size(75, 23);
            this.ProductAdded.TabIndex = 33;
            this.ProductAdded.Text = "Ekle";
            this.ProductAdded.UseVisualStyleBackColor = true;
            // 
            // CateforyAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ProductList);
            this.Controls.Add(this.ProductAdded);
            this.Controls.Add(this.tbxContactName);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CateforyAddForm";
            this.Text = "CateforyAddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxContactName;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProductList;
        private System.Windows.Forms.Button ProductAdded;
    }
}