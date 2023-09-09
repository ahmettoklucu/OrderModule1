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
    public partial class CategoryListForm : Form
    {
        private int userId;
        public CategoryListForm(int _userId)
        {
            InitializeComponent();
            this.userId = _userId;
            _categoryService=new CategoryManager(new EfCategoryDal());
        }
        private int _categoryId;
        private ICategoryService _categoryService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(userId); 
            menuForm.Show();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            CateforyAddForm cateforyAddForm = new CateforyAddForm(userId);
            cateforyAddForm.Show();
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_categoryId != 0)
                {
                    CategoryUpdateForm categoryUpdateForm = new CategoryUpdateForm(userId, _categoryId);
                    categoryUpdateForm.Show();

                }
                else
                {
                    MessageBox.Show("Güncellemek için bir veri seçiniz!!");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
           
        }
        public void LoadCategory()
        {
            dgwProduct.DataSource = _categoryService.GetAll();
        }
        private void CategoryListForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _categoryId= Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_categoryId != 0)
                {
                    var DeleteCategory = _categoryService.Get(_categoryId);
                    _categoryService.Delete(DeleteCategory);
                    MessageBox.Show("Kategori Silindi.");
                    LoadCategory();

                }
                else
                {
                    MessageBox.Show("Silmek için bir veri seçiniz!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(tbxProductName.Text))
                {
                    dgwProduct.DataSource = _categoryService.GetCategoryByCategoryName(tbxProductName.Text);
                }
                else
                {
                    LoadCategory();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
