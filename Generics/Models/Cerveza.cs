using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fundamentals_in_CSharp.Models
{
    internal class Cerveza : Bebida, IBebidaAlcoholica
    {
        public int Alcohol { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El máximo permitido son 10");
        }
        public Cerveza(int Cantidad, string Nombre="Cerveza") 
            : base(Nombre, Cantidad) 
        {
            
            
        }


    }
}
