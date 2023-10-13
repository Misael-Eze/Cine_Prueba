using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class Sala
    {
        public int NroSala { get; set; }
        public List<Butaca> Butacas { get; set; }
        public Sala()
        {
            NroSala = 0;
            Butacas = new List<Butaca>();
        }
        public Sala(int nroSala, List<Butaca> lbutacas)
        {
            NroSala = nroSala;
            Butacas = lbutacas;
        }
    }
}
