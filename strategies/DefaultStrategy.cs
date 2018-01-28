using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplicationAleja
{
    public class DefaultStrategy : IPreguntasProcesorRule
    {
        public string Resolver(string a, string b)
        {
            return "No entiendo la pregunta .Buscando en google busquedas parecidas...";
        }
    }
}
