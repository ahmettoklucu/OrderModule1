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
    public partial class SupplierAddForm : Form
    {
        private int userId;
        public SupplierAddForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            _supplierService =new SupplierManager(new EfSupplierDal());
        }
        private ISupplierService _supplierService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(userId);
            menuForm.ShowDialog();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            SupplierListForm form = new SupplierListForm(userId);
            form.Show();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _supplierService.Add(new Supplier
                {
                    CompanyName = tbxCompanyName.Text,
                    ContactName = tbxContactName.Text,
                    ContactTitle = tbxContactTitle.Text,
                    Country = tbxCountry.Text,
                    Fax = tbxFax.Text,
                    Phone = tbxPhone.Text,
                    PostalCode = tbxPostalCode.Text,
                    Region = tbxRegion.Text,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
