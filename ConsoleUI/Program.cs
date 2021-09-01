using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine("Product Id = " + product.ProductId + " Product Name = " + product.ProductName);
            }

            Console.WriteLine("************************************************************");

            int i = 0;

            foreach (var product in productManager.GetByUnitPrice(0,500000))
            {
                i += 1;
                Console.WriteLine("Number = " + i + " Product Id = " + product.ProductId + " Product Name = " + product.ProductName + " Unit Price = " + product.UnitPrice);
            }
        }
    }
}
