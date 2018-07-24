using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCEPuerto
    {
        //Constructor
        public SCEPuerto()
        {
            SCEInstruccion1 = new HashSet<SCEInstruccion>();
            SCEInstruccion2 = new HashSet<SCEInstruccion>();
        }
        //Attribute
        public string IdPuerto { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public string Tipo { get; set; }
        public short Estado { get; set; }
        //Navigation
        public virtual ICollection<SCEInstruccion> SCEInstruccion1 { get; set; }
        public virtual ICollection<SCEInstruccion> SCEInstruccion2 { get; set; }
    }
}