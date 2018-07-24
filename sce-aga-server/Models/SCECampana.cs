using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sce_aga_server.Models
{
    public class SCECampana
    {
        //Constructor
        public SCECampana()
        {
            SCEProyeccionComercial = new HashSet<SCEProyeccionComercial>();
        }
        //Attribute
        public string IdCampaña { get; set; }
        public string Descripcion { get; set; }
        public string IdCultivo { get; set; }
        public short Estado { get; set; }
        public virtual ICollection<SCEProyeccionComercial> SCEProyeccionComercial { get; set; }
    }
}