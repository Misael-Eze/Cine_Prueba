using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class FormaPago
    {
        public int IdFormaPago { get; set; }
        public string Forma { get; set; }
        public FormaPago()
        {
            IdFormaPago = 0;
            Forma = string.Empty;
        }
        public FormaPago(int id, string forma)
        {
            IdFormaPago = id;
            Forma = forma;            
        }
    }
}
