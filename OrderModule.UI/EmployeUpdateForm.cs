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
    public partial class EmployeUpdateForm : Form
    {
        public EmployeUpdateForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeesForm = new EmployeeListForm();
            employeesForm.Show();
        }
    }
}
