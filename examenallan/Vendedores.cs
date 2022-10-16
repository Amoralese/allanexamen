using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examenallan
{
    internal class Vendedores
    {
        public string vendedor { get; set; }

        public Vendedores() { }

        public void listavebdedor()
        {
            Dictionary<string, string> vendedores = new Dictionary<string, string>();
            vendedores.Add("1","vendedor1");
            vendedores.Add("2", "vendedor2");
            foreach (var vendedor in vendedores)
            {
                Console.WriteLine($"llave: {vendedor.Key} valor: {vendedor.Value}");
            }
            Console.Read();
        }
        
      
	

	}
}



    
