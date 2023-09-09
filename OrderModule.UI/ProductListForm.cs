using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Concrete;
using OrderModule.DataAccess.Concrete;
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
    public partial class ProductListForm : Form
    {
        private int userId;
        public ProductListForm(int _userId)
        {
            InitializeComponent();
            this.userId = _userId;
            _productService = new ProductManager(new EfProductDal());
            _categoryService=new CategoryManager(new EfCategoryDal());
            _supplierService=new SupplierManager(new EfSupplierDal());


        }
        private int _product;
        private IProductService _productService;
        private ICategoryService _categoryService;
        private ISupplierService _supplierService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadSupplier();
            LoadProduct();
            
            
        }
        public void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }
        private void LoadCategory()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }
        private void LoadSupplier()
        {
            cbxSupplier.DataSource = _supplierService.GetAll();
            cbxSupplier.DisplayMember = "CompanyName";
            cbxSupplier.ValueMember = "SupplierID";
        }
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxCategory.SelectedIndex != 0)
                {

                    dgwProduct.DataSource = _productService.GetProductByCategory(cbxCategory.SelectedIndex);
                }
                else
                {
                    LoadProduct();
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
                    dgwProduct.DataSource = _productService.GetProductByProductName(tbxProductName.Text);
                }
                else
                {
                    LoadProduct();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            ProductAddForm product = new ProductAddForm(userId);

            product.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(userId);
            menuForm.Show();
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            if (_product != 0)
            {
                ProductUpdateForm productUpdateForm = new ProductUpdateForm(userId,_product);
                productUpdateForm.Show();
            }
            else
            {
                MessageBox.Show("Güncellemek için bir veri seçiniz!!");
            }

            
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _product =Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(_product!=0)
            {
                var DeleteProduct = _productService.Get(_product);
                _productService.Delete(DeleteProduct);
                LoadProduct();
            }
            else
            {
                MessageBox.Show("Silmek için bir veri seçiniz!!");
            }
           
        }

        private void cbxSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxSupplier.SelectedIndex != 0)
                {
                    dgwProduct.DataSource = _productService.GetProductBySupplier(cbxSupplier.SelectedIndex);
                }
                else
                {
                    LoadProduct();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
