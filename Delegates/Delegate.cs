

namespace Delegates
{
    public delegate void Imprimir<T>(T value);
    internal class Delegate
    {
        public void ImprimirPantalla(string value)
        {
            Console.WriteLine(value);
        }

        public void ImprimirEntero(int value)
        {
            Console.WriteLine(value);
        }

        public void ExampleDelegate()
        {
            Imprimir<string> imprimirDel = new Imprimir<string>(ImprimirPantalla);
            Imprimir<int> imprimirEntero = new Imprimir<int>(ImprimirEntero);
            imprimirDel("Texto");
            imprimirEntero(5);
        }

        public void ExampleAction()
        {
            // PASAR UNA FUNCION POR PARAMETRO A OTRA CLASE.
            Action<string> actionExample = ImprimirPantalla;
        }
    }
}
