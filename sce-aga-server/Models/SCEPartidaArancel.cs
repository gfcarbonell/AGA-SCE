using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCEPartidaArancel
    {
        //Constructor
        public SCEPartidaArancel()
        {
            SCEInstruccion = new HashSet<SCEInstruccion>();
        }
        //Attribute
        public string IdPartida { get; set; }
        public string Descripcion { get; set; }
        public string IdCultivo { get; set; }
        //Navigation
        public short Estado { get; set; }
        public virtual ICollection<SCEInstruccion> SCEInstruccion { get; set; }
    }
}