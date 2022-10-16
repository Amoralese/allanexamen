using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class Categorias
    {
        public int categ1 { get; set; }
        public int categ2  { get; set; }
        public int categ3 { get; set; }
        
        public Categorias()
        {
            categ1 = 1;
            categ2 = 2;
            categ3 = 3;

        }

        public void ListadoCategoria()
        {

            string[] Categ = { "categ1", "categ2", "categ3" };

            List<string> lista = new List<string>();
            lista.Add("categ1");
            lista.Add("categ2");
            lista.Add("categ3");
            foreach (var art in lista)
            {
                Console.WriteLine(art);
            }



            Console.Read();
        }
         public void promocion() { Console.WriteLine("descuentos y promociones"); }

        

        


        
    }
}
