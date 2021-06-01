using ParcialLPPA.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ParcialLPPA.Servicios;


namespace ParcialLPPA.Negocios
{
    public class AfiliadoNegocio
    {
        public void Agregar (Afiliado model)
        {
            var db = new BaseDataService<Afiliado>();
            db.Create(model);

        }
        public List<Afiliado> Listar()
        {
            var db = new BaseDataService<Afiliado>();
            var lista = db.get();
            return lista;
        }
    }
}