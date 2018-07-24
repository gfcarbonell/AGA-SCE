using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCEMercado
    {
        //Constructor
        public SCEMercado()
        {
            SCEProyeccionComercial = new HashSet<SCEProyeccionComercial>();
        }
        //Attribute
        public string IdMercado { get; set; }
        public string Descripcion { get; set; }
        public short Estado { get; set; }
        //Navigation
        public virtual ICollection<SCEProyeccionComercial> SCEProyeccionComercial { get; set; }
    }
}