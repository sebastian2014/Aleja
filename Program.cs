using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAleja
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "4";
            string b = "5";

             var tokenizador = new Tokenizador();

            var resultado = tokenizador.Resolve("Cuanto es", a, b);

            Console.WriteLine(resultado);
            Console.ReadKey();


        }
    }
}
