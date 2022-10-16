using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class categoria2: Categorias
    {
        public string  promo { get; set; }
        public categoria2() { }

        public void promocion() { Console.WriteLine("promocion 2X1"); }
    }
}
