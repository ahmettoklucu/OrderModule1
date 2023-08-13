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
        public ProductListForm()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService=new CategoryManager(new EfCategoryDal());


        }
        private IProductService _productService;
        private ICategoryService _categoryService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadProduct();
            
            
        }
        public void LoadProduct()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }
        public void LoadCategory()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCategory.SelectedIndex!=null)
            {
                
                dgwProduct.DataSource= _productService.GetProductByCategory(cbxCategory.SelectedIndex);
            }
            else
            {
                LoadProduct();
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {

                dgwProduct.DataSource = _productService.GetProductByProductName(tbxProductName.Text);

        }
    }
}
