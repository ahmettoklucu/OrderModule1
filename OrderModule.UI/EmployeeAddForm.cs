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
    public partial class EmployeeAddForm : Form
    {
        private int userId;
        public EmployeeAddForm(int _UserId)
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal());
            userId = _UserId;
        }
        private IEmployeeService _employeeService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(userId);
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            EmployeeListForm  employeeListForm = new EmployeeListForm(userId);
            employeeListForm.Show();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.Add(new Employee
                {
                    LastName = tbxLastName.Text,
                    FirstName = tbxFirstName.Text,
                    Title = tbxTitle.Text,
                    Address = tbxAddress.Text,
                    City = tbxCity.Text,
                    PostalCode = tbxPostalCode.Text,
                    TitleOfCourtesy = tbxTitleOfCourtesy.Text,

                });
                MessageBox.Show("İşçi eklendi.");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
