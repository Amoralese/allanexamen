using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class categoria3: Categorias
    {
        public string promo { get; set; }
        public categoria3() { }

        public void promocion() { Console.WriteLine("todo a mitad de precio"); }
    }
}
