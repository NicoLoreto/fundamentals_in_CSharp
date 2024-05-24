using System.Linq;

/* Sirve para hacer consultas a colecciones */

namespace LINQ.Models {
    class Program
    {
        static async Task Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 7, 62, 3, 0 };

            // Al método se le pasa un predicado. Es lo que deberá hacer la función.
            // d será la colección de números.
            var numero7 = numeros.Where(d => d == 7).FirstOrDefault();

            Console.WriteLine(numero7);

            // Ordenados
            var numerosOrdenados = numeros.OrderBy(numeros => numeros);

            foreach (var n in numerosOrdenados)
            {
                Console.WriteLine(n.ToString());
            }

            // Suma
            var suma = numeros.Sum(d => d);
            Console.WriteLine(suma);

            // Promedio
            var promedio = numeros.Average(d => d);
            Console.WriteLine(promedio);

            // Sintaxis alternada a C#.

            List<Cerveza> cervezas = new List<Cerveza>()
        {

            new Cerveza(2){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
            new Cerveza(2){ Alcohol=9, Cantidad=1, Marca="Palermo"},

        };

            List<Bebida> bebidas = new List<Bebida>()
        {
            new Bebida("Gaseosa", 2){ Marca = "Manaos"},
            new Bebida("Gaseosa", 2){ Marca="Paso de los toros"},
        };

            var cervezasOrdenadas = cervezas.OrderBy(cerveza => cerveza.Nombre).ToList();

            foreach (var cerveza in cervezasOrdenadas)
            {
                Console.WriteLine(cerveza);
            }

            // Objetos complejos
            var bares = new List<Bar>()
            {
                new Bar("El bar")
            {
                cervezas = new List<Cerveza>()
                {
                    new Cerveza(2){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                    new Cerveza(2){ Alcohol=9, Cantidad=1, Marca="Palermo"},
                }
            },

            new Bar("El bar dos")
            {
                cervezas = new List<Cerveza>()
                {
                    new Cerveza(2){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                    new Cerveza(2){ Alcohol=9, Cantidad=1, Marca="Palermo"},
                    new Cerveza(2){ Alcohol=9, Cantidad=1, Marca="Quilmes"},
                }
            },
            new Bar("El bar to")
            {
                cervezas = new List<Cerveza>()
                {
                    new Cerveza(2){ Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                    new Cerveza(2){ Alcohol=9, Cantidad=1, Marca="Palermo"},
                    new Cerveza(2){ Alcohol=9, Cantidad=1, Marca="Stella Artois"},
                }
            }
        };

            // Buscar en una lista de bares si tiene la cerveza Quilmes
            var bar = (from d in bares
                         where d.cervezas.Where(c => c.Marca == "Quilmes").Count() > 0
                         select d).ToList();

            var barMasEspefíofico = (from d in bares
                                     where d.cervezas.Where(c => c.Marca == "Palermo").Count() > 0
                                     select new BarData(d.nombre)
                                     {
                                         bebidas = (from c in d.cervezas
                                                    select new Bebida(c.Nombre, c.Cantidad)).ToList(),

                                     });

            Console.WriteLine(bar);


        }
    } 
}