using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAleja
{
    class LocalizacionStrategy: IPreguntasProcesorRule
    {
       
        public string Resolver(string a, string b)
        {
            return "Esta a tres cuadras no jodas...";
        }
    }
}
