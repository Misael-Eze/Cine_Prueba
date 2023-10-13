using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class Pelicula
    {
        public int PeliculaNro { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public string Idioma { get; set; }
        public int Duracion { get; set;}
        public string Clasificacion { get; set;}
        public Pelicula()
        {
            PeliculaNro = 0;
            Titulo = string.Empty;
            Genero = string.Empty;
            Director = string.Empty;
            Idioma = string.Empty;
            Duracion = 0;
            Clasificacion = string.Empty;
        }
        public Pelicula(int nro, string tit, string gen, string dir, string idi, int dur, string clas)
        {
            PeliculaNro = nro;
            Titulo = tit;
            Genero = gen;
            Director = dir;
            Idioma = idi;
            Duracion = dur;
            Clasificacion = clas;
        }
    }
}
