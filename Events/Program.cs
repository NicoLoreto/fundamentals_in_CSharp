// Editor y suscriptor. Ejecutor y el método a ejecutar.
// Un evento es un delegate encapsulado. 

namespace Events
{
    static class Program
    {
        static void Main(string[] args)
        {
            SubscriptionVirtualCalculator VirtualCalculator =  new SubscriptionVirtualCalculator(2,3);
            VirtualCalculator.OperationSubtract();
            VirtualCalculator.OperationSum();
        }


    }
}

