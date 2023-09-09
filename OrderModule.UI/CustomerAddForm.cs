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
    public partial class CustomerAddForm : Form
    {
        private int userId;
        public CustomerAddForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            _customerService=new CustomerManager(new EFCustomerDal());
        }
        private ICustomerService _customerService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(userId);
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm(userId);
            customerListForm.Show();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _customerService.Add(new Customer
                {
                    ContactName=tbxContactName.Text,
                    CompanyName=tbxCompanyName.Text,
                    ContactTitle=tbxContactTitle.Text,
                    Address=tbxAddress.Text,
                    City=tbxCity.Text,
                    Region=tbxRegion.Text,
                    PostalCode=tbxPostalCode.Text,
                    Country=tbxCity.Text,
                    Phone=tbxPhone.Text,
                    Fax=tbxFax.Text,
                });
                MessageBox.Show("Müşteri eklendi.");
                CustomerListForm customerListForm = new CustomerListForm(userId);
                customerListForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
