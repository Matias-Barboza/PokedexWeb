using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokedexCapaDominio
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public Elemento Tipo { get; set; }
        public Pokemon Evolucion { get; set; }
        public Elemento TipoDebilidad { get; set; }
        public string UrlImagen { get; set; }
        public bool Activo { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
