
using fundamentals_in_CSharp.Models;
using System.Runtime.CompilerServices;

namespace fundamentals_inCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insertamos una cerveza.
            CervezaBD cervezaBD = new CervezaBD();

            Cerveza cerveza = new Cerveza(1, "Rubia");
            cerveza.Marca = "Quilmes";
            cerveza.Alcohol = 9;

            cervezaBD.Add(cerveza);

            // Obtenemos todas las cervezas.
            var cervezas = cervezaBD.Get();

            foreach (var c in cervezas)
            {
                Console.WriteLine(c.Nombre);
            }

            // Editamos una cerveza.
            Cerveza cerveza2 = new Cerveza(1, "Morocha");
            cerveza.Marca = "Quilmes Stout";
            cerveza.Alcohol = 12;

            cervezaBD.Edit(cerveza2, 1);

            // Eliminamos una cerveza.
            cervezaBD.Delete(1);

        }

        static void MostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
        {
            bebidaAlcoholica.MaxRecomendado();
        }
      
    }
}
