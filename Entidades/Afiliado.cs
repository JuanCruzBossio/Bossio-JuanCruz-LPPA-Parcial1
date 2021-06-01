using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialLPPA.Entidades
{
    public class Afiliado:Identidad
    {
        public Afiliado()
        {

        }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public int telefono { get; set; }
        public int cuil { get; set; }
    }
}