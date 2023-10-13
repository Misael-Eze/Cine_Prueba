using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace CineApp.Entidades
{
    internal class Vendedor
    {
        public int VendedorId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }
        public Vendedor()
        {
            VendedorId = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Dni = 0;
        }
        public Vendedor(int id, string nom, string ape, int dni)
        {
            VendedorId= id;
            Nombre= nom;
            Apellido= ape;
            Dni = dni;
        }
    }
}
