using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class EditorCalculator
    {
        public delegate void ExampleDelegate();
        public event ExampleDelegate eventExample;
        public void Sumar(int a, int b)
        {
            if (eventExample != null)
            {
                Console.WriteLine($"La suma es {a + b}");
            }
            else
            {
                Console.WriteLine("no estas suscripto a los eventos");
            }

        }

        public void Restar(int a, int b)
        {
            if (eventExample != null)
            {
                Console.WriteLine($"La suma es {a - b}");
            }
            else
            {
                Console.WriteLine("no estas suscripto a los eventos");
            }

        }


    }
}
