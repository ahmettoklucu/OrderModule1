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
    public partial class ProductUpdateForm : Form
    {
        public ProductUpdateForm()
        {
            InitializeComponent();
            _categoryService = new CategoryManager(new EfCategoryDal());
            _supplierService = new SupplierManager(new EfSupplierDal());
            _productService = new ProductManager(new EfProductDal());
        }
        private ICategoryService _categoryService;
        private ISupplierService _supplierService;
        private IProductService _productService;
        public void LoadCategory()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }
        public void LoadSupplier()
        {
            cbxSupplier.DataSource = _supplierService.GetAll();
            cbxSupplier.DisplayMember = "CompanyName";
            cbxSupplier.ValueMember = "SupplierID";
        }
        private void ProductList_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();

            productListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadSupplier();
        }

        private void SupplierAdd_Click(object sender, EventArgs e)
        {
            SupplierAddForm supplierAddForm = new SupplierAddForm();
            supplierAddForm.Show();
        }

        private void CategoryAdd_Click(object sender, EventArgs e)
        {
            CateforyAddForm cateforyAddForm = new CateforyAddForm();
            cateforyAddForm.Show();
        }
    }
}
