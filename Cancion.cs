using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab14_bibliotecaMusica
{
    public class Cancion
    {
        public string Nombre { get; set; }
        public string Artista { get; set; }
        public string TiempoDuracion { get; set; }

        public Cancion()
        {
            Nombre = string.Empty;
            Artista = string.Empty;
            TiempoDuracion = string.Empty;
        }
    }

}
