using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Models
{
    // LINQ tambien sirve para tratar objetos complejos (objetos dentro de objetos)
    internal class Bar
    {
        public string nombre { get; set; }
        public Bar(string nombre)
        {
            this.nombre = nombre;
        }
        public List<Cerveza> cervezas { get; set; }
    }
}
