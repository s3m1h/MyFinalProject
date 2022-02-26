using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // attribute - classla ilgili bilgi verme - imzalama
    // naming convention
    // IoC container 
    public class ProductsController : ControllerBase
    {
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet] 
        public List<Product> Get()
        {
            //IProductService productService = new ProductManager(new EfProductDal());
            var result = _productService.GetAll();
            return result.Data;
        
        }
    }
}
