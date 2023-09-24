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
    public partial class OrderUpdateForm : Form
    {
        public OrderUpdateForm(int UserId, int _orderId1)
        {
            InitializeComponent();
            userId = UserId;
            _orderId= _orderId1;
            _orderService = new OrderManager(new EfOrderDal());
            _orderDetailService = new OrderDetailManager(new EfOrderDetailDal());
            _customerService = new CustomerManager(new EFCustomerDal());
            _employeeService = new EmployeeManager(new EfEmployeeDal(), new EfEmployeeTerritoryDal(), new EfOrderDetailDal(), new EfOrderDal());
            _productService=new ProductManager(new EfProductDal());
        }
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private IProductService _productService;
        private ICustomerService _customerService;
        private IEmployeeService _employeeService;
        private int userId;
        private int _orderId;
        private void LoadProduct()
        {
            cbxProduct.DataSource = _productService.GetAll();
            cbxProduct.DisplayMember = "ProductName";
            cbxProduct.ValueMember = "ProductID";
        }
        private void LoadCustomer()
        {
            cbxCustomer.DataSource = _customerService.GetAll();
            cbxCustomer.DisplayMember = "CompanyName";
            cbxCustomer.ValueMember = "CustomerID";
        }
        private void LoadEmployee()
        {
            cbxEmployee.DataSource = _employeeService.GetAll();
            cbxEmployee.DisplayMember = "FirstName" + " " + "LastName";
            cbxEmployee.ValueMember = "EmployeeID";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm(userId);
            menuForm.Show();
        }

        private void ProductList_Click(object sender, EventArgs e)
        {
            OrderListForm orderListForm = new OrderListForm(userId);
            orderListForm.Show();
        }

        private void OrderUpdateForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadEmployee();
            LoadProduct();
        }

        private void ProductAdded_Click(object sender, EventArgs e)
        {

        }
    }
}
