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
    public partial class OrderListForm : Form
    {
        public OrderListForm()
        {
            InitializeComponent();
            _orderService=new OrderManager(new EfOrderDal());
            _orderDetailService = new OrderDetailManager(new EfOrderDetailDal());
        }
        private IOrderService _orderService;
        private IOrderDetailService _orderDetailService;
        private int _orderId;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (_orderId != 0)
                {
                    var DeletedOrder = _orderService.Get(_orderId);
                    _orderService.Delete(DeletedOrder);
                    var DeletedOrderDetail = _orderDetailService.SingleOrderOrderDetail(_orderId);
                    foreach (var item in DeletedOrderDetail)
                    {
                        _orderDetailService.Delete(item);
                    }
                    MessageBox.Show("Sipariş Silindi.");
                    LoadOrder();
                }
                else
                {
                    MessageBox.Show("Silmek için bir veri seçiniz!!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _orderId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value.ToString());
        }

        private void ProductUpdate_Click(object sender, EventArgs e)
        {
            OrderUpdateForm form = new OrderUpdateForm(_orderId);
            form.Show();
        }
    }
}
