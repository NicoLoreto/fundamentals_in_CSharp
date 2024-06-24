using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance_Contravariance
{
    public class Ejemplo
    {
        public static void imprimir(List<Persona> personas)
        {
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo: {persona.GetType().ToString()}");
            }
        }

        public static void imprimir(IEnumerable<Persona> personas)
        {
            foreach (Persona persona in personas)
            {
                Console.WriteLine($"El elemento actual es de tipo: {persona.GetType().ToString()}");
            }
        }

        public static void RealizarAccionBecario(Action<Becario> actionBecario)
        {
            Becario becario = new Becario();
            actionBecario(becario);
        }
    }
}
