using OrderModule.Bussiness.Abstract;
using OrderModule.Bussiness.Utilities;
using OrderModule.Bussiness.ValidationRules.FluentValidation;
using OrderModule.DataAccess.Abstract;
using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Concrete
{
    public class OrderManager : IOrderService
    {
        private IOrderDal _orderDal;
        public OrderManager(IOrderDal orderDal) 
        { 
            _orderDal = orderDal;

        }
        public void Add(Order order)
        {
            ValidationTool.Validate(new OrderValidator(), order);
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
           _orderDal.Delete(order);
        }

        public Order Get(int orderId)
        {
            return _orderDal.Get(P=>P.OrderID==orderId);
        }

        public List<Order> GetAll()
        {
           return _orderDal.GetAll();
        }

        public void Update(Order order)
        {
            ValidationTool.Validate(new OrderValidator(), order);
           _orderDal.Update(order);
        }
    }
}
