using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAleja
{
   public class MatematicaStrategy: IPreguntasProcesorRule
    {
     public string Resolver(string a, string b)
     {
         return $"El resultado es : {(Convert.ToInt32(a) + Convert.ToInt32(b))}";
     }
    }
}
