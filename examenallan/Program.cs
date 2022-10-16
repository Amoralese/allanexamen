using examenallan;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string articulo = "artic";
            int factura = 123;
            int reporte = 12;
            string salir = "salir";
            int opcion=0;

            do
            {
                Console.WriteLine("1- artic");
                Console.WriteLine("2- factura");
                Console.WriteLine("3- reprte");
                Console.WriteLine("4- salir");
                Console.WriteLine(" digite una opcion");
                opcion = int.Parse (Console.ReadLine());

                switch (opcion)
                {
                    case 1: Console.WriteLine("opcion 1 marcada"); break;
                    case 2: Console.WriteLine("opcion 2 marcada"); break;
                    case 3: Console.WriteLine("opcion 3 marcada"); break;
                    case 4: break;


                    default:
                        break;
                }

                Console.Read();

            } while (opcion!=5);
        }
    }
}
