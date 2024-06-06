using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaDominio
{
    public class Elemento
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Elemento() { }

        public Elemento(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
