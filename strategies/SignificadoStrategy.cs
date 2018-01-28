using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAleja
{
   public class SignificadoStrategy : IPreguntasProcesorRule
    {
        //¿cómo se dice a ​hola en ​ b griego?
        public string Resolver( string a, string b)
        {
            return $"{a} en {b}  Se dice  chau ";

            // mapear de una tabla o servicio que traduzca o busque en google
        }

      
       
    }
}
