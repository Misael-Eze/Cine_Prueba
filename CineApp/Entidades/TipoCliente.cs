using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class TipoCliente
    {
        public Cliente oCliente { get; set; }
        public string Tipo { get; set; }

        public TipoCliente()
        {
            oCliente = new Cliente();
            Tipo = string.Empty;
        }
        public TipoCliente(Cliente cliente, string tipo)
        {
            oCliente = cliente;
            Tipo = tipo;
        }
    }
}
