//// See https://aka.ms/new-console-template for more information
//using Business.Concrete;
//using DataAccess.Concrete.EntityFramework;
//using DataAccess.Concrete.InMemory;

//// Data Transformation Object
//// CategoryManagerTest();
//// ProductManagerTest();
//// IoC



//// GetProductDetailsTest();

//void CategoryManagerTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//    foreach (var category in categoryManager.GetAll())
//    {
//        Console.WriteLine(category.CategoryName);
//    }
//}

//void ProductManagerTest()
//{
//    //ProductManager productManager = new ProductManager(new InMemoryProductDal());
//    ProductManager productManager = new ProductManager(new EfProductDal());
//    foreach (var product in productManager.GetAllByUnitPrice(40, 100).Data)
//    {
//        Console.WriteLine(product.ProductName);
//    }
//}

//static void GetProductDetailsTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal());

//    var result = productManager.GetProductDetails();

//    if (result.Success == true)
//    {
//        foreach (var product in result.Data)
//        {
//            Console.WriteLine("{0} / {1} / {2}", product.ProductID, product.ProductName, product.CategoryName);
//        }

//    }
//    else
//    {
//        Console.WriteLine(result.Message);
//    }
//}