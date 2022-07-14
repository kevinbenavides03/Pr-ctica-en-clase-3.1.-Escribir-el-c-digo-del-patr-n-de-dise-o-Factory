﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CreateProductA : Creator
    {
        public CreateProductA(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IProduct CreateProduct(String Nombre)
        {
            Console.WriteLine(" - CreateProductA / CreateProduct()");

            ProductA product = new ProductA("Iphone xplus");
            product.Nombre = Nombre;

            return product;
        }
    }
}