using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.Entidades
{
    internal class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Contacto { get; set; }
        
        public Cliente()
        {
            ClienteId = 0;
            Nombre = string.Empty;
            Contacto = string.Empty;
        }
        public Cliente(int id, string nom, string con)
        {
            ClienteId = id;
            Nombre = nom;
            Contacto = con;
        }
    }
}
