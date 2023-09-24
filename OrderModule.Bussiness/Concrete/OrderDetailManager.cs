using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Utilities;
using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private IOrderDetailDal _orderDetailDal;
        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void Add(OrderDetail orderDetail)
        {
            //ValidationTool.Validate(new ordde)
            _orderDetailDal.Add(orderDetail);
        }

        public void Delete(OrderDetail orderDetail)
        {
           _orderDetailDal.Delete(orderDetail);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailDal.GetAll();
        }

        public List<OrderDetail> SingleOrderDetail(int orderId)
        {
           return _orderDetailDal.GetAll(p=>p.OrderID== orderId);
        }

        public void Update(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
        }
    }
}
