using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab14_bibliotecaMusica
{
    public class Album
    {
        public string Titulo { get; set; }
        public string Artista { get; set; }
        public List<Cancion> Canciones { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public Album()
        {
            Titulo = string.Empty;
            Artista = string.Empty;
            Canciones = new List<Cancion>();
            FechaPublicacion = DateTime.MinValue;
        }
    }
}
