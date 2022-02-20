// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

// ProductManagerTest();
// IoC
CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
foreach (var category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}



void ProductManagerTest()
{
    //ProductManager productManager = new ProductManager(new InMemoryProductDal());
    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var product in productManager.GetAllByUnitPrice(40, 100))
    {
        Console.WriteLine(product.ProductName);
    }
}



