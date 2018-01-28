using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAleja
{
   public class Tokenizador
    {
        readonly IDictionary<string, IPreguntasProcesorRule> _lstPreguntasStrategy = new Dictionary<string, IPreguntasProcesorRule>
            {
                {"cuanto es", new MatematicaStrategy()},
                {"como se dice", new SignificadoStrategy()},
                {"como llego", new LocalizacionStrategy()},
            };

        
       public string Resolve(string pattern ,string a, string b)
       {
            if (!_lstPreguntasStrategy.ContainsKey(pattern.ToLower()))
            {
                return new DefaultStrategy().Resolver(a, b);
            }

            //tambien se puede llamar directamente a las estrategias, sin pasar por el procesador
             //lstPreguntasStrategy desde este punto.
            //var result = lstPreguntasStrategy[pattern].Resolver(a, b);

            var result = _lstPreguntasStrategy[pattern.ToLower()];

            var procesadorPreguntas = new ProcesadorPreguntas(result);

           return procesadorPreguntas.Resolver(a, b);


       }
    }
}
