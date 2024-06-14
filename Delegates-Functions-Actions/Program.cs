// Delegados: Tipo que almacena una firma sobre una función y si regresa o no regresa un dato. El objetivo es agregar funcionalidad a una funcionalidad
// que ya existe.
// Los metodos estaticos pertenecen a la clase, no al objeto.

public class Program
{
    //delegate void Mostrar(string cadena);
    static async Task Main(string[] args)
    {
        // macheo con el tipo Mostrar mas el nombre de la funcion.
        //mostrar mostrar = Show;
        Func<string, int> mostrar = Show;

        Action<string, string> mostrarDos = (a, b) 
            => Console.WriteLine(a + " " + b);    
        HacerAlgo(mostrar);
        HacerAlgoMas(mostrarDos);
    }

    // Func
    public static void HacerAlgo(Func<string, int> funcionFinal)
    {
        Console.WriteLine(funcionFinal("Hola soy un delegado"));
    }

    // Action
    public static void HacerAlgoMas(Action<string, string> funcionFinal)
    {
        funcionFinal("Hola soy una cadena,", "más otra cadena");
    }


    public static int Show(string cad)
    {

        return cad.Count();

    }

    // Con Func se devuelve el último parámetro, antes iran los parámetros que recibe, evitando hacer delegado por delegado.
    // Action funciona parecido a Func, solo que Action nunca regresa nada, sino que ejecuta algo.


}
