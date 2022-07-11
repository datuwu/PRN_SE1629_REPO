using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();
        public IEnumerable<OrderDetail> GetOrderDetailListByMemberID(int id) => OrderDetailDAO.Instance.GetOrderDetailListByMemberID(id);
        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderID, ProductID);
        public double GetStatistic(IEnumerable<Order> id) => OrderDetailDAO.Instance.GetStatistic(id);
        public IEnumerable<OrderDetail> GetOrderDetailListByListOrder(IEnumerable<Order> id) => OrderDetailDAO.Instance.GetOrderDetailListByListOrder(id);
        public IEnumerable<OrderDetail> GetOrderDetailListByListOrder(List<Order> id) => OrderDetailDAO.Instance.GetOrderDetailListByListOrder(id);
        public void InsertOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.AddNew(OrderDetail);
        public void DeleteOrderDetail(int OrderID, int ProductID) => OrderDetailDAO.Instance.Remove(OrderID, ProductID);
        public void UpdateOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.Update(OrderDetail);

    }
}