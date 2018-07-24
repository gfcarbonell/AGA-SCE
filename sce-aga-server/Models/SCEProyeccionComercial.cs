using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCEProyeccionComercial
    {
        //Constructor
        public SCEProyeccionComercial()
        {
            SCEInstruccion = new HashSet<SCEInstruccion>();
        }
        //Attribute
        public int IdProyeccion { get; set; }
        public string IdCampaña { get; set; }
        public string Periodo { get; set; }
        public short Semana { get; set; }
        public string IdCliente { get; set; }
        public string IdMercado { get; set; }
        public string idVariedad { get; set; }
        public string IdEmbalaje { get; set; }
        public decimal Cantidad { get; set; }
        public short Estado { get; set; }
        public short UsuarioCreacion { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public short? UsuarioModificacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        //Navigation
        public virtual SCECampana SCECampana { get; set; }
        public virtual SCEClienteProveedor SCEClienteProveedor { get; set; }
        public virtual ICollection<SCEInstruccion> SCEInstruccion { get; set; }
        public virtual SCEMercado SCEMercado { get; set; }
    }
}