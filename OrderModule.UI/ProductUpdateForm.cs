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
    public partial class ProductUpdateForm : Form
    {
        private int _product;
        private int _userId;
        public ProductUpdateForm(int userId, int product)
        {
            InitializeComponent();
            _product = product;
            _userId = userId;
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
        public void LoadProduct()
        {
            var UpdatedProduct= _productService.Get(_product);
            tbxProductName.Text=UpdatedProduct.ProductName.ToString();
            cbxCategory.SelectedValue = UpdatedProduct.CategoryID;
            cbxSupplier.SelectedValue = UpdatedProduct.SupplierID;
            tbxQuantityPerUnit.Text=UpdatedProduct.QuantityPerUnit.ToString();
            nmrUnitInStock.Value = UpdatedProduct.UnitPrice;
            nmrUnitInStock.Value = UpdatedProduct.UnitsInStock;

        }
        private void ProductList_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm(_userId);

            productListForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_userId);
            menuForm.Show();
        }

        private void ProductUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadSupplier();
            LoadProduct();
        }

        private void SupplierAdd_Click(object sender, EventArgs e)
        {
            SupplierAddForm supplierAddForm = new SupplierAddForm(_userId);
            supplierAddForm.Show();
        }

        private void CategoryAdd_Click(object sender, EventArgs e)
        {
            CateforyAddForm cateforyAddForm = new CateforyAddForm(_userId);
            cateforyAddForm.Show();
        }

        private void ProductUpdated_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductID = _product,
                    ProductName = tbxProductName.Text,
                    CategoryID = Convert.ToInt32(cbxCategory.SelectedValue),
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitsInStock = Convert.ToInt16(nmrUnitInStock.Value),
                    UnitPrice = Convert.ToDecimal(nmrUnitInStock.Value),
                    SupplierID = Convert.ToInt32(cbxSupplier.SelectedValue),

                });
                MessageBox.Show("Ürün güncelleştirildi.");
                ProductListForm productListForm = new ProductListForm(_userId);
                productListForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
