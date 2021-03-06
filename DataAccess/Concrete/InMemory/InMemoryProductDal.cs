using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> 
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Kupa Bardak",UnitPrice=15,UnitsInStock=20},
                new Product{ProductId=2,CategoryId=2,ProductName="Pepsi Kola",UnitPrice=500,UnitsInStock=10},
                new Product{ProductId=3,CategoryId=2,ProductName="Peçete",UnitPrice=15,UnitsInStock=220},
                new Product{ProductId=4,CategoryId=3,ProductName="Tahta Kalem",UnitPrice=10,UnitsInStock=100},
                new Product{ProductId=5,CategoryId=3,ProductName="Telefon",UnitPrice=5000,UnitsInStock=2},
                new Product{ProductId=6,CategoryId=4,ProductName="Akıllı Saat",UnitPrice=400,UnitsInStock=3},
                new Product{ProductId=7,CategoryId=4,ProductName="Monster Laptop Çantası",UnitPrice=300,UnitsInStock=4},
            
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - language ıntegrated query

            //Product productToDelete =null;
            //foreach (var p in _products)
            //{
            //    if(p.ProductId == product.ProductId)
            //    {
            //        productToDelete = p;
            //    }
            //}


            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;
        }
    }
}
