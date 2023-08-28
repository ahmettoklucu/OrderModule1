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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
            _orderService=new OrderManager(new EfOrderDal());
        }
        private IOrderService _orderService;
        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            OrderAddForm orderAddForm = new OrderAddForm();
            orderAddForm.Show();
        }
        private void LoadOrder()
        {
            dgwProduct.DataSource=_orderService.GetAll();
        }

        private void OrderListForm_Load(object sender, EventArgs e)
        {
            LoadOrder();
        }
    }
}
