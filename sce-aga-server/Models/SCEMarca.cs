using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCEMarca
    {
        //Constructor
        public SCEMarca()
        {
            SCEInstruccionDetalle = new HashSet<SCEInstruccionDetalle>();
        }
        //Attribute
        public string IdMarca { get; set; }
        public string Descripcion { get; set; }
        public short Estado { get; set; }
        //Navigation
        public virtual ICollection<SCEInstruccionDetalle> SCEInstruccionDetalle { get; set; }
    }
}