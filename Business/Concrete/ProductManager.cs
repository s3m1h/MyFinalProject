using Business.Abstract;
using Business.Constants;
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
                return new ErrorDataResult<Product>(Messages.ProductNameInvalid);
            }
            else
            {
                _productDal.Add(product);
                return new SuccessDataResult<Product>(Messages.ProductAdded);
            }
        }

        public IDataResult<List<Product>> GetAll()
        {
            if(DateTime.Now.Hour == 10)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            // iş kodları
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);

        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            var data = _productDal.GetAll(p => p.CategoryId == id);
            return new SuccessDataResult<List<Product>>(data,"");
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(int min, int max)
        {
            var result = _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
            return new SuccessDataResult<List<Product>>(result,"message") ;
        }

        public IDataResult<Product> GetProductById(int id)
        {
            var result = _productDal.Get(p => p.ProductId == id);
            return new SuccessDataResult<Product>(result, "message");
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            var result = _productDal.GetProductDetails();
            return new SuccessDataResult<List<ProductDetailDto>>(result,"message");
        }
    }
}
