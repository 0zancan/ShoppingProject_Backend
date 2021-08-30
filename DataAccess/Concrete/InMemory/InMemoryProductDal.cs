using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            // Bir database üzerinden geliyormuş gibi simüle etmek için;
            _products = new List<Product> {
            new Product{ CategoryId = 1, ProductId = 1, ProductName = "Laptop", UnitPrice = 6000, UnitsInStock = 10},
            new Product{ CategoryId = 1, ProductId = 2, ProductName = "HardDisk", UnitPrice = 300, UnitsInStock = 50},
            new Product{ CategoryId = 2, ProductId = 3, ProductName = "Camera", UnitPrice = 1000, UnitsInStock = 100},
            new Product{ CategoryId = 2, ProductId = 4, ProductName = "GoPro", UnitPrice = 1300, UnitsInStock = 10}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ kullanmadan bu şekilde yapılabilir.
            //foreach (var item in _products)
            //{
            //    if(item.ProductId == product.ProductId)
            //    {
            //        productToDelete = item;
            //    }
            //}

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);

        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(x => x.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
