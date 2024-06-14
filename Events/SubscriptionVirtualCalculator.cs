using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class SubscriptionVirtualCalculator
    {
        private EditorCalculator editor;
        private int A;
        private int B;
        public void ExampleEventHandlder()
        {
            Console.WriteLine("La operación ha sido ejecutada");
        }

        public SubscriptionVirtualCalculator(int a, int b)
        {
            editor = new EditorCalculator();
            A = a;
            B = b;
            // Suscribirse a los eventos. Se llama a un delegado, por lo tanto se le puede pasar una función.
            // se usa += para suscribirse y -= para desuscribirse.
            editor.eventExample += ExampleEventHandlder;
        }

        public void OperationSum()
        {
            editor.Sumar(A, B);
        }

        public void OperationSubtract()
        {
            editor.Restar(A, B);
        }
    }
}
