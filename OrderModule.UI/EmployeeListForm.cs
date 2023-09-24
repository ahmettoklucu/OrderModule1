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
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderModule.UI
{
    public partial class EmployeeListForm : Form
    {
        private int _employeeId;
        private int _UserId;
        public EmployeeListForm(int userId)
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal(),new EfEmployeeTerritoryDal(), new EfOrderDetailDal(),new EfOrderDal());
            _UserId= userId;
        }
        private IEmployeeService _employeeService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(_UserId);
            menuForm.Show();
        }
        private void ProductAdd_Click(object sender, EventArgs e)
        {
            EmployeeAddForm employeeAddForm = new EmployeeAddForm(_UserId);
            employeeAddForm.Show();
        }
        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (_employeeId != 0)
                {
                    EmployeUpdateForm employeUpdateForm = new EmployeUpdateForm(_UserId, _employeeId);
                    employeUpdateForm.Show();
                }
                else
                {
                    MessageBox.Show("Güncellemek için bir veri seçiniz!!");
                }

            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }
        public void LoadUmployee()
        {
            dgwProduct.DataSource = _employeeService.GetAll();
        }
        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            LoadUmployee();
        }
        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _employeeId=Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value.ToString());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_employeeId != 0)
                {
                    var DeleteEmployee = _employeeService.Get(_employeeId);
                    _employeeService.Delete(DeleteEmployee);
                    LoadUmployee();
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
