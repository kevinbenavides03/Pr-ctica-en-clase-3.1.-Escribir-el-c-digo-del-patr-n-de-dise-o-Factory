using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CreateProductB : Creator
    {
        public CreateProductB(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IProduct CreateProduct(String Nombre)
        {
            Console.WriteLine(" - CreateProductB / CreateProduct()");
            ProductB product = new ProductB("XiamoRedmi A10", 2022);
            product.Nombre = Nombre;
            return product;
        }
    }
}