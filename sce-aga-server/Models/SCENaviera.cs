using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCENaviera
    {
        //Constructor
        public SCENaviera()
        {
            SCEInstruccion = new HashSet<SCEInstruccion>();
        }
        //Attribute
        public string IdNaviera { get; set; }
        public string Descripcion { get; set; }
        public short Estado { get; set; }
        //Navigation
        public virtual ICollection<SCEInstruccion> SCEInstruccion { get; set; }
    }
}