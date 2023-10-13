using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class Funciones
    {
        public int FuncionId { get; set; }
        public Pelicula oPelicula { get; set; }
        public Sala oSala { get; set; }
        public DateTime Dia { get; set; }
        public DateTime Hora { get; set; }
        public Funciones()
        {
            FuncionId = 0;
            oPelicula = null;
            oSala = null;
            Dia = DateTime.Today;
            Hora = DateTime.UtcNow;
        }
        public Funciones(int id, Pelicula pelicula, Sala sala, DateTime dia, DateTime hora)
        {
            FuncionId = id;
            oPelicula = pelicula;
            oSala = sala;
            Dia = dia;
            Hora = hora;
        }

    }
}
