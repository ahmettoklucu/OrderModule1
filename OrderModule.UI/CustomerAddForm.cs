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
        private int _userId;
        public CustomerAddForm(int userId)
        {
            InitializeComponent();
            _userId = userId;
            _customerService=new CustomerManager(new EFCustomerDal(), new EfCustomerCustomerDemoDal(), new EfOrderDal(), new EfOrderDetailDal());
        }
        private ICustomerService _customerService;
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

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                if(_customerService.Get(CustomerId.Text) == null) 
                {
                    _customerService.Add(new Customer
                    {
                        CustomerID = CustomerId.Text,
                        ContactName = tbxContactName.Text,
                        CompanyName = tbxCompanyName.Text,
                        ContactTitle = tbxContactTitle.Text,
                        Address = tbxAddress.Text,
                        City = tbxCity.Text,
                        Region = tbxRegion.Text,
                        PostalCode = tbxPostalCode.Text,
                        Country = tbxCity.Text,
                        Phone = tbxPhone.Text,
                        Fax = tbxFax.Text,
                        Saved = _userId,
                        SavedDate = DateTime.Now,
                        Updated = _userId,
                        UpdatedDate = DateTime.Now,
                    });
                    MessageBox.Show("Müşteri eklendi.");
                    CustomerListForm customerListForm = new CustomerListForm(_userId);
                    customerListForm.Show();
                }
                else
                {
                    MessageBox.Show("Müşteri Kodu mevcuttur.");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
