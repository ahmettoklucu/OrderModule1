using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Concrete;
using OrderModule.DataAccess.Concrete;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderModule.UI
{
    public partial class CateforyAddForm : Form
    {
        public CateforyAddForm()
        {
            InitializeComponent();
            _categoryService=new CategoryManager(new EfCategoryDal());

        }
        private ICategoryService _categoryService;

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryListForm = new CategoryListForm();
            categoryListForm.Show();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Add(new Category
                {
                    CategoryName = tbxCategoryName.Text,
                    CategoryDescription = tbxCategoryDescription.Text,

                });
                MessageBox.Show("Ürün Kaydedildi");
                ProductListForm productListForm = new ProductListForm();
                productListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }
    }
}
