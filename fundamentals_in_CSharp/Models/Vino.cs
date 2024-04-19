using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals_in_CSharp.Models
{
    internal class Vino : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 30");
        }
        public Vino(int Cantidad, string Nombre = "Vino")
            : base(Nombre, Cantidad)
        {


        }
    }
    }
