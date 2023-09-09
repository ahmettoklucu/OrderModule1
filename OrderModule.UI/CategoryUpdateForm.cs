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
        private int _userId;
        public CategoryUpdateForm(int userId, int categoryId)
        {
            InitializeComponent();
            _userId = userId;
            _categoryId = categoryId;
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
            MenuForm menuForm = new MenuForm(_userId);
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            CategoryListForm categoryListForm = new CategoryListForm(_userId);
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
                    Updated = _userId,
                    UpdatedDate = DateTime.Now,

                });
                MessageBox.Show("Kategori Güncellendi.");
                CategoryListForm categoryListForm = new CategoryListForm(_userId);
                categoryListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
