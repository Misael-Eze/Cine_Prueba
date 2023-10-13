using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class TipoSala
    {
        public Sala oSala { get; set; }
        public string Tipo { get; set; }
        public TipoSala()
        {
            oSala = new Sala();
            Tipo = string.Empty;
        }
        public TipoSala(Sala sala, string tipo)
        {
            oSala = sala;
            Tipo = tipo;
        }

    }
}
