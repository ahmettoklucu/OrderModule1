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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderListForm orderListForm = new OrderListForm();
            orderListForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(); 
            employeeListForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CustomerListForm customerListForm = new CustomerListForm();
            customerListForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SupplierListForm supplierListForm = new SupplierListForm();
            supplierListForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProductListForm productListForm = new ProductListForm();
            productListForm.Show();
        }
    }
}
