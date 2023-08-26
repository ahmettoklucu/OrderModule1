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
    public partial class CustomerListForm : Form
    {
        public CustomerListForm()
        {
            InitializeComponent();
            _customerService=new CustomerManager(new EFCustomerDal());
        }
        private ICustomerService _customerService;
        private string _customerId;
        public void LoadCustomer()
        {
            dgwProduct.DataSource = _customerService.GetAll();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(); 
            menuForm.Show();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAddForm = new CustomerAddForm();
            customerAddForm.Show();
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_customerId != null)
                {
                    CustomerUpdateForm categoryUpdateForm = new CustomerUpdateForm(_customerId);
                    categoryUpdateForm.Show();

                }
                else
                {
                    MessageBox.Show("Güncellemek için bir veri seçiniz!!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void CustomerListForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _customerId = (dgwProduct.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_customerId != null)
                {
                    var DeleteCustomer = _customerService.Get(_customerId);
                    _customerService.Delete(DeleteCustomer);
                    MessageBox.Show("Müşteri Silindi.");
                    LoadCustomer();

                }
                else
                {
                    MessageBox.Show("Silmek için bir veri seçiniz!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
