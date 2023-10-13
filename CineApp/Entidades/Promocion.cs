using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineApp.Entidades
{
    internal class Promocion
    {
        public int IdPromocion { get; set; }
        public string TipoPromocion { get; set; }
        public Day DiaPromocion { get; set; }
        public double Descuento { get; set; }

        public Promocion()
        {
            IdPromocion = 0;
            TipoPromocion = string.Empty;
            DiaPromocion = new Day();
            Descuento = 0;
        }
        public Promocion(int id, string tipo, Day dia, double descuento)
        {
            IdPromocion = id;
            TipoPromocion = tipo;
            DiaPromocion = dia;
            Descuento = descuento;
        }
    }
}
