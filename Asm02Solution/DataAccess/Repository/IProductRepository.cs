using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductID);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductID);
        void UpdateProduct(Product Product);
        public List<Product> Filter(String name, string unitprice, string unitinstock, string id);
        public List<Product> GetProductByUnitInStock(int param);
        public List<Product> GetProductByUnitPrice(decimal param);
        public List<Product> GetProductByName(String param);
        List<Product> GetProductByUnitPriceAndUnitInStock(int a, int b);

    }
}
