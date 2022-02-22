﻿using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            if(product.ProductName.Length < 2)
            {
                return new ErrorResult();
            }
            else
            {
                _productDal.Add(product);
                return new SuccessResult();
            }
        }

        public List<Product> GetAll()
        {
            // iş kodları
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId ==id);
        }

        public List<Product> GetAllByUnitPrice(int min, int max)
        {
            return _productDal.GetAll(p=>p.UnitPrice>=min&& p.UnitPrice<=max);
        }

        public Product GetProductById(int id)
        {
            return _productDal.Get(p=>p.ProductId == id);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
