using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCEInstruccionDetalle
    {
        //Attribute
        public int IdInstruccionDetalle { get; set; }
        public int IdInstruccion { get; set; }
        public string IdMarca { get; set; }
        public string IdProducto { get; set; }
        public string IdVariedad { get; set; }
        public decimal Peso { get; set; }
        public string IdEmbalaje { get; set; }
        public decimal Cantidad { get; set; }
        public short Estado { get; set; }
        //Navigate
        public virtual SCEInstruccion SCEInstruccion { get; set; }
        public virtual SCEMarca SCEMarca { get; set; }
    }
}