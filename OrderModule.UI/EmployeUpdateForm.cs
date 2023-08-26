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
    public partial class EmployeUpdateForm : Form
    {
        private int _employeeId;
        public EmployeUpdateForm(int employeeId)
        {
            InitializeComponent();
            _employeeId = employeeId;
            _employeeService=new EmployeeManager(new EfEmployeeDal());
        }
        private IEmployeeService _employeeService;
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
        public void LoadEmployee()
        {
            var UpdateEmployee = _employeeService.Get(_employeeId);
            tbxFirstName.Text = UpdateEmployee.FirstName;
            tbxLastName.Text = UpdateEmployee.LastName;
            tbxTitle.Text = UpdateEmployee.Title;
            tbxPostalCode.Text = UpdateEmployee.PostalCode;
            tbxTitleOfCourtesy.Text = UpdateEmployee.TitleOfCourtesy;
            tbxAddress.Text = UpdateEmployee.Address;
            tbxCity.Text = UpdateEmployee.City;
        }
        private void EmployeUpdateForm_Load(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        private void ProductAdded_Click(object sender, EventArgs e)
        {
            try
            {
                _employeeService.Update(new Employee
                {
                    EmployeeID = _employeeId,
                    FirstName=tbxFirstName.Text,
                    LastName=tbxLastName.Text,
                    Title=tbxTitle.Text,
                    PostalCode=tbxPostalCode.Text,
                    Address=tbxAddress.Text,
                    City=tbxCity.Text,
                    TitleOfCourtesy=tbxTitleOfCourtesy.Text,
                });
                MessageBox.Show("Ürün Güncelleştirildi.");
                EmployeeListForm employeeListForm = new EmployeeListForm();
                employeeListForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
