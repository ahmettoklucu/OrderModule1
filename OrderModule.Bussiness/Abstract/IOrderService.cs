using OrderModule.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.Bussiness.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order Get(int orderId);
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
