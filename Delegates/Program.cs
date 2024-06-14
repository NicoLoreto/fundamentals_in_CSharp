// Modificador de acceso - delegate - tipo de retorno
// Action: devuelve void siempre. Func: Recibe uno o más parámetros y devuelve un parámetro. Predicate: Devuelve true o false.

namespace Delegates
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Delegate del1 = new Delegate();
            del1.ExampleDelegate();
        }

    public void AlternativeClass(Action<string> action)
        {
            action("imprimir");
        }
    }
}