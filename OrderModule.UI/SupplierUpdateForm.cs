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
    public partial class SupplierUpdateForm : Form
    {
        private int _supplierıd;
        private int _userId;
        private ISupplierService _supplierService;
        public SupplierUpdateForm(int userId, int suppplierId1)
        {
            InitializeComponent();
            _userId = userId;
            _supplierıd = suppplierId1;
            _supplierService = new SupplierManager(new EfSupplierDal());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_userId);
            menuForm.Show();
        }

        public void LoadSuplier()
        {
            var UpdateSupplier = _supplierService.Get(_supplierıd);
            tbxAddress.Text = UpdateSupplier.Address;
            tbxCity.Text = UpdateSupplier.City;
            tbxCompanyName.Text = UpdateSupplier.CompanyName;
            tbxContactName.Text = UpdateSupplier.ContactName;
            tbxContactTitle.Text = UpdateSupplier.ContactTitle;
            tbxCountry.Text = UpdateSupplier.Country;
            tbxFax.Text = UpdateSupplier.Fax;
            tbxPhone.Text = UpdateSupplier.Phone;
            tbxPostalCode.Text = UpdateSupplier.PostalCode;
            tbxRegion.Text = UpdateSupplier.Region;
           


        }
        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _supplierService.Update(new Supplier
                {
                    SupplierID=_supplierıd,
                    CompanyName=tbxCompanyName.Text,
                    ContactName=tbxContactName.Text,
                    ContactTitle=tbxContactTitle.Text,
                    Country=tbxCountry.Text,
                    Fax=tbxFax.Text,
                    Phone=tbxPhone.Text,
                    PostalCode=tbxPostalCode.Text,
                    Region=tbxRegion.Text,
                    Updated = _userId,
                    UpdatedDate = DateTime.Now,

                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SupplierUpdateForm_Load(object sender, EventArgs e)
        {
            LoadSuplier();
        }
    }
}
