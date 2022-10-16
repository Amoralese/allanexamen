using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class categoria1: Categorias
    {
        public string promo { get; set; }
        public categoria1() { }

        public void promocion() { Console.WriteLine("descuento del 15%"); }


    }
    
}
