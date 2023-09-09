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
    public partial class ProductAddForm : Form
    {
        private int _userId;
        public ProductAddForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _categoryService = new CategoryManager(new EfCategoryDal());
            _supplierService=new SupplierManager(new EfSupplierDal());
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
        private void ProductAdd_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadSupplier();

        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product
                {
                    CategoryID = cbxCategory.SelectedIndex,
                    SupplierID = cbxSupplier.SelectedIndex,
                    ProductName = tbxProductName.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(nmrUnitPrice.Text),
                    Saved = _userId,
                    SavedDate = DateTime.Now,
                    Updated = _userId,
                    UpdatedDate = DateTime.Now,

                });
                MessageBox.Show("Ürün Kaydedildi");
                ProductListForm productListForm = new ProductListForm(_userId);
                productListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm(_userId);

            productListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm= new MenuForm(_userId);
            menuForm.Show();

        }

        private void SupplierAdd_Click(object sender, EventArgs e)
        {
            SupplierAddForm supplierAddForm= new SupplierAddForm(_userId);
            supplierAddForm.Show();
        }

        private void CategoryAdd_Click(object sender, EventArgs e)
        {
            CateforyAddForm cateforyAddForm= new CateforyAddForm(_userId); 
            cateforyAddForm.Show();
        }
    }
}
