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
        private int _userId;
        public EmployeeAddForm(int UserId)
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal(),new EfEmployeeTerritoryDal(),new EfOrderDetailDal(),new EfOrderDal());
            _userId = UserId;
        }
        private IEmployeeService _employeeService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_userId);
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            EmployeeListForm  employeeListForm = new EmployeeListForm(_userId);
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
                    Country=tbxCountry.Text,
                    Region = tbxRegion.Text,
                    Saved = _userId,
                    SavedDate = DateTime.Now,
                    Updated = _userId,
                    UpdatedDate = DateTime.Now,
                    HomePhone=tbxPhone.Text,

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
