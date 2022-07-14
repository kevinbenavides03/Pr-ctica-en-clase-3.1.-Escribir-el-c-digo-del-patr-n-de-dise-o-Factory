using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ProductA : IProduct
    {
        public String Nombre { get; set; }
        public String Local { get; set; }
        public ProductA(String Local)
        {
            this.Local = Local;
        }

        public void doStuf()
        {
            Console.WriteLine(" - Estoy en ProductA / doStuf()");
            Console.WriteLine(" - Cargo: " + this.Nombre);
            Console.WriteLine(" - - - Empresa: " + this.Local);
        }
    }
}