// Covariance: Cuando creamos colecciones inmutables lo hacemos para evitar quitar o añadir elementos de dichas colecciones.
// Usamos out en el tipo genérico para indicar que es covariance. IEnumerable usamos para esto.
// De esta manera podemos pasar cualquier tipo que herede de nuestra lista principal.

// Contravariance: Lo usamos cuando pasamos funciones como parámetros.
namespace Covariance_Contravariance
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Invariance: Permite solo el tipo que se le indica.
            List<Persona> persona = new List<Persona>()
            {
                new Becario(),
                new Jefe(),

            };

            Ejemplo.imprimir(persona);

            // Covariance: Utiliza out, permite un tipo o los que hereden de él.
            List<Becario> becarios = new List<Becario>()
            {
                new Becario(),
                new Becario(),

            };

            Ejemplo.imprimir(becarios);

            // Contravariance: Utiliza in. Permite un tipo o sus tipos padre.
            var actionBecario = new Action<Becario>(a => Console.WriteLine("Preparar café"));
            Ejemplo.RealizarAccionBecario(actionBecario);

            // No acepta el tipo
            //var actionJefe = new Action<Jefe>(a => Console.WriteLine("Preparar meeting"));
            //Ejemplo.RealizarAccionBecario(actionJefe);

            // Action aceptará clases y sus padres.
            var actionEmpleado = new Action<Empleado>(a => Console.WriteLine("Preparar meeting"));
            Ejemplo.RealizarAccionBecario(actionEmpleado);
        }

    }
}

// CONCLUSIÓN
/*
 * la covarianza es útil cuando se quiere tratar una colección de tipos derivados (más específicos) como una 
 * colección de tipos base. Es útil para tipos que solo producen (devuelven) valores.
 * La contravarianza es útil cuando se quiere pasar una función que 
 * trabaja con tipos base a un contexto donde se esperan tipos derivados.
 * Es útil para tipos que solo consumen (aceptan) valores.
 * 
 */