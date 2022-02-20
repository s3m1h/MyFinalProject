using Core.Entities;
using System;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // class ların default erişim tanımı internaldir
    // public ile diğer katmanlarada erişimi acmıs olduk
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
