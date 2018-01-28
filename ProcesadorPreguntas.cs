using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplicationAleja
{
   public class ProcesadorPreguntas
    {
        private IPreguntasProcesorRule _preguntasProcesorRule;


       public ProcesadorPreguntas(IPreguntasProcesorRule preguntasProcesorRule)
       {
           this._preguntasProcesorRule = preguntasProcesorRule;
       }

       public string Resolver(string a, string b)
       {
           return _preguntasProcesorRule.Resolver(a,b);
       }


    }
}
