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
    public partial class EmployeeListForm : Form
    {
        public EmployeeListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employeeAddForm = new EmployeeAddForm();
            employeeAddForm.Show();
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            EmployeUpdateForm employeUpdateForm = new EmployeUpdateForm();
            employeUpdateForm.Show();

        }
    }
}
