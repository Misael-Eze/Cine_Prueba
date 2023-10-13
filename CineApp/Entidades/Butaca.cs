using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class Butaca
    {
        public int NroButaca { get; set; }
        public string Estado { get; set; } //Añadir una enum para que diga cualquiera de las 3 opciones

        public Butaca()
        {
            NroButaca = 0;
            Estado = "Libre";
        }

        public Butaca(int nro, string estado)
        {
           NroButaca = nro;
           Estado = estado;
        }
    }
}
