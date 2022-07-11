using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject.Models;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<Product> GetProducts() => ProductDAO.Instance.GetProductList();
        public Product GetProductByID(int ProductID) => ProductDAO.Instance.GetProductByID(ProductID);
        public void InsertProduct(Product Product) => ProductDAO.Instance.AddNew(Product);
        public void DeleteProduct(int ProductID) => ProductDAO.Instance.Remove(ProductID);
        public void UpdateProduct(Product Product) => ProductDAO.Instance.Update(Product);
        public List<Product> Filter(String name, string unitprice, string unitinstock, string id) => ProductDAO.Instance.Filter(name, unitprice, unitinstock, id);
        public List<Product> GetProductByUnitInStock(int param) => ProductDAO.Instance.GetProductByUnitInStock(param);
        public List<Product> GetProductByUnitPrice(decimal param) => ProductDAO.Instance.GetProductByUnitPrice(param);
        public List<Product> GetProductByName(String param) => ProductDAO.Instance.GetProductByName(param);
        public List<Product> GetProductByUnitPriceAndUnitInStock(int a, int b) => ProductDAO.Instance.Filter(a, b);

    }
}
