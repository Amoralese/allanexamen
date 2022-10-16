using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class articulos
    {



        public void articulo() { }

        public int codigo { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
        public articulos(int codigo, string nombre, int precio)
        {
            this.codigo=codigo;
            this.nombre=nombre;
            this.precio=precio;
        }
        public void agregar() { Console.WriteLine("agregar articulo"); }
        public void consultar() { Console.WriteLine("consultar articulos"); }
        public void borrar() { Console.WriteLine("borrar articulo"); }
        public articulos()
        {

            string[] articulos = new string[] { "art1", "art2", "art3", "art4", "ar5" };
            int[] art = new int[5];
            art[0]= 1;
            art[1]= 2;
            art[2]= 3;
            art[3]= 4;
            art[4]= 5;
            int mayor = art[5];
            
            foreach (var articulo in articulos)
            {
                Console.WriteLine("articulo");
            }

                Console.Read();





            }


        }

    }





    
    
    

