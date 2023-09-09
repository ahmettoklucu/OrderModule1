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
    public partial class CustomerUpdateForm : Form
    {
        private string _customerId;
        private int _userId;
        private ICustomerService _customerService;
        public CustomerUpdateForm(int userId, string customerId)
        {
            InitializeComponent();
            _userId = userId;
            _customerId = customerId;
            _customerService=new CustomerManager(new EFCustomerDal());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_userId);
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm(_userId);
            customerListForm.Show();
        }
        public void LoadCustomer()
        {
            var UpdateCustomer = _customerService.Get(_customerId);
            tbxCompanyName.Text = UpdateCustomer.CompanyName;
            tbxContactName.Text = UpdateCustomer.ContactName;
            tbxContactTitle.Text = UpdateCustomer.ContactTitle;
            tbxCountry.Text = UpdateCustomer.Country;
            tbxFax.Text = UpdateCustomer.Fax;
            tbxAddress.Text = UpdateCustomer.Address;
            tbxCity.Text = UpdateCustomer.City;
            tbxRegion.Text = UpdateCustomer.Region;
            tbxPostalCode.Text = UpdateCustomer.PostalCode;
            tbxPhone.Text = UpdateCustomer.Phone;
        }

        private void CustomerUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.Update(new Customer
                {
                    CustomerID = _customerId,
                    CompanyName=tbxCompanyName.Text,
                    ContactName=tbxContactName.Text,    
                    ContactTitle=tbxContactTitle.Text,
                    Country=tbxCountry.Text,
                    Fax=tbxFax.Text,
                    Address=tbxAddress.Text,
                    City=tbxCity.Text,
                    Region=tbxRegion.Text,
                    PostalCode=tbxPostalCode.Text,
                    Phone=tbxPhone.Text,
                    Updated = _userId,
                    UpdatedDate = DateTime.Now,
                });
                MessageBox.Show("Müşteri Güncelleştirildi.");
                CustomerListForm customerListForm = new CustomerListForm(_userId);
                customerListForm.Show();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
