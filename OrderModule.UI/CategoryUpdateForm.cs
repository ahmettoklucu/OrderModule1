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
    public partial class CategoryUpdateForm : Form
    {
        private int _categoryId;
        public CategoryUpdateForm(int _categoryId)
        {
            InitializeComponent();
            _categoryService=new CategoryManager(new EfCategoryDal());
        }
        public void LoadCategory()
        {
            var UpdateCategory =_categoryService.Get(_categoryId);
            tbxCategoryName.Text = UpdateCategory.CategoryName;
            tbxDescription.Text = UpdateCategory.CategoryDescription;
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

        private void CategoryUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryService.Update(new Category
                {
                    CategoryName = tbxCategoryName.Text,
                    CategoryDescription = tbxDescription.Text,
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
