using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using sce_aga_server.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using System.Configuration;

namespace sce_aga_server.Services
{
    public class SCEEncargadoServicio : ISCEEncargado
    {
        Database objDB = DatabaseFactory.CreateDatabase("AGA-SCE");
        String Esquema = ConfigurationManager.AppSettings.Get("Esquema").ToString();

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Exist(int Id)
        {
            throw new NotImplementedException();
        }

        public ICollection<SCEEncargado> Get()
        {
            List<SCEEncargado> encargados = new List<SCEEncargado>();
            try
            {
                DbCommand cmd;
                cmd = objDB.GetStoredProcCommand(Esquema + ".[PR_SCE_ENCARGADO_QRY]");
                //objDB.AddInParameter(cmd, "@IdVariedad", DbType.String, obje.IdVariedad);
                //objDB.AddInParameter(cmd, "@Sucursal", DbType.String, obje.Sucursal);
                //objDB.AddInParameter(cmd, "@Peso", DbType.Decimal, obje.Peso);
                //objDB.AddInParameter(cmd, "@IdProyectado", DbType.Int32, obje.IdProyectado);
                //objDB.AddInParameter(cmd, "@Usuario", DbType.String, Usuario);
                //objDB.AddInParameter(cmd, "@NumActualizado", DbType.Int32, obje.NumActualizado);

                foreach (DataRow dr in objDB.ExecuteDataSet(cmd).Tables[0].Rows)
                {
                    SCEEncargado pr = new SCEEncargado();
                    pr.IdEncargado = dr[0].ToString();
                    pr.Descripcion = dr[1].ToString();
                    encargados.Add(pr);
                }
            }
            catch (Exception e)
            {
                encargados = null;
            }
            return encargados;            
        }

        public SCEEncargado Save(SCEEncargado entidad)
        {
            throw new NotImplementedException();
        }

        public SCEEncargado Update(SCEEncargado entidad)
        {
            throw new NotImplementedException();
        }
    }
}