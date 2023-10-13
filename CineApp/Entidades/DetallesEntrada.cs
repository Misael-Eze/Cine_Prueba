using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class DetallesEntrada
    {
        public int IdDetalle { get; set; }
        public Funciones oFuncion { get; set; }
        public FormaPago oFormaPago { get; set; }
        public Promocion oPromocion { get; set; }
        public double Precio { get; set; }
        public Butaca oButaca { get; set; }
        public DetallesEntrada()
        {
            IdDetalle = 0;
            oFuncion = new Funciones();
            oFormaPago = new FormaPago();
            oPromocion = new Promocion();
            Precio = 0;
            oButaca = new Butaca();
        }
        public DetallesEntrada(int id, Funciones funcion, FormaPago forma, Promocion promo, double prec, Butaca butaca)
        {
            IdDetalle = id;
            oFuncion = funcion;
            oFormaPago = forma;
            oPromocion = promo;
            Precio = prec;
            oButaca = butaca;
        }

    }
    
}
