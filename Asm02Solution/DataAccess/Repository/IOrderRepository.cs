using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        IEnumerable<Order> GetOrderListByMemberID(int id);
        Order GetOrderByID(int OrderID);
        void InsertOrder(Order order);
        void DeleteOrder(int OrderID);
        void UpdateOrder(Order order);
        List<Order> GetOrderByOrderdDate(DateTime dateTime1, DateTime dateTime2);
    }
}
