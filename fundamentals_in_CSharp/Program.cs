
using fundamentals_in_CSharp.Models;
using System.Text.Json;

namespace fundamentals_inCSharp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            /*
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
            */

        // Usando interfaces.
        static void MostrarRecomendacion(IBebidaAlcoholica bebidaAlcoholica)
        {
            bebidaAlcoholica.MaxRecomendado();
        }

        // Usando serialización.
        var Cerveza = new Cerveza(10, "Cerveza");
         
        string miJson = JsonSerializer.Serialize(Cerveza);

        // Guardar los atos del json en un archivo de texto.
        File.WriteAllText("objeto.txt", miJson);

            // Cargar el archivo y obtener objeto.
            string json = File.ReadAllText("Tracking-hours.txt");

            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(json);

            Console.WriteLine(json);

        }
    }
}
