using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess
{
    public class OrderDetailDAO
    {
        //Using Singleton Pattern
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var members = new List<OrderDetail>();
            try
            {
                using var context = new FStore2Context();
                members = context.OrderDetails.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;

        }
        public IEnumerable<OrderDetail> GetOrderDetailListByMemberID(int id)
        {
            var list = new List<OrderDetail>();
            var members = new List<Order>();
            var fil = new List<Order>();
            var final = new List<OrderDetail>();
            try
            {
                using var context = new FStore2Context();
                members = context.Orders.ToList();
                list = context.OrderDetails.ToList();
                for (int i = 0; i < members.Count(); i++)
                {
                    if (members[i].MemberId == id)
                    {
                        fil.Add(members[i]);
                    }
                }
                for (int i = 0; i < fil.Count(); i++)
                {
                    for (int z = 0; z < list.Count(); z++)
                    {
                        if (fil[i].OrderId == list[z].OrderId)
                        {
                            final.Add(list[z]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return final;
        }
        public IEnumerable<OrderDetail> GetOrderDetailListByListOrder(IEnumerable<Order> id)
        {
            var list = new List<OrderDetail>();
            var fil = id.ToList();
            var final = new List<OrderDetail>();
            try
            {
                using var context = new FStore2Context();
                list = context.OrderDetails.ToList();
                for (int i = 0; i < fil.Count(); i++)
                {
                    for (int z = 0; z < list.Count(); z++)
                    {
                        if (fil[i].OrderId == list[z].OrderId)
                        {
                            final.Add(list[z]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return final;
        }

        public IEnumerable<OrderDetail> GetOrderDetailListByListOrder(List<Order> id)
        {
            var list = new List<OrderDetail>();
            var final = new List<OrderDetail>();
            try
            {
                using var context = new FStore2Context();
                list = context.OrderDetails.ToList();
                for (int i = 0; i < id.Count(); i++)
                {
                    for (int z = 0; z < list.Count(); z++)
                    {
                        if (id[i].OrderId == list[z].OrderId)
                        {
                            final.Add(list[z]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return final;
        }

        public double GetStatistic(IEnumerable<Order> id)
        {
            double total = 0.0;
            var x = GetOrderDetailListByListOrder(id).ToList();
            foreach (var z in x)
            {
                total += z.Quantity * (double)z.UnitPrice - (z.Quantity * (double)z.UnitPrice * (z.Discount / 100));
            }
            return total;
        }

        public OrderDetail GetOrderDetailByID(int OrderID, int ProductID)
        {
            OrderDetail mem = null;
            try
            {
                using var context = new FStore2Context();
                mem = context.OrderDetails.SingleOrDefault(c => c.OrderId == OrderID && c.ProductId == ProductID);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void AddNew(OrderDetail OrderDetail)
        {
            try
            {
                OrderDetail mem = GetOrderDetailByID(OrderDetail.OrderId, OrderDetail.ProductId);
                if (mem == null)
                {
                    using var context = new FStore2Context();
                    context.OrderDetails.Add(OrderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Add a new member
        public void Update(OrderDetail OrderDetail)
        {
            try
            {
                OrderDetail mem = GetOrderDetailByID(OrderDetail.OrderId, OrderDetail.ProductId);
                if (mem != null)
                {
                    using var context = new FStore2Context();
                    context.OrderDetails.Update(OrderDetail);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The OrderDetail does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Add a new member
        public void Remove(int OrderId, int ProductId)
        {
            try
            {
                OrderDetail mem = GetOrderDetailByID(OrderId, ProductId);
                if (mem != null)
                {
                    using var context = new FStore2Context();
                    context.OrderDetails.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The  OrderDetail does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
