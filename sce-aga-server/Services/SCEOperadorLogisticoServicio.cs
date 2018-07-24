using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using Microsoft.Practices.EnterpriseLibrary.Data;
using sce_aga_server.Models;

namespace sce_aga_server.Services
{
    public class SCEOperadorLogisticoServicio : ISCEOperadorLogistico
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

        public ICollection<SCEOperadorLogistico> Get()
        {
            List<SCEOperadorLogistico> operadoresLogisticos = new List<SCEOperadorLogistico>();
            try
            {
                DbCommand cmd;
                cmd = objDB.GetStoredProcCommand(Esquema + ".[PR_SCE_OPERADOR_LOGISTICO_QRY]");
                foreach (DataRow dr in objDB.ExecuteDataSet(cmd).Tables[0].Rows)
                {
                    SCEOperadorLogistico pr = new SCEOperadorLogistico();
                    pr.IdOperador = dr[0].ToString();
                    pr.Descripcion = dr[1].ToString();
                    operadoresLogisticos.Add(pr);
                }
            }
            catch (Exception e)
            {
                operadoresLogisticos = null;
            }
            return operadoresLogisticos;
        }

        public SCEOperadorLogistico Save(SCEOperadorLogistico entidad)
        {
            throw new NotImplementedException();
        }

        public SCEOperadorLogistico Update(SCEOperadorLogistico entidad)
        {
            throw new NotImplementedException();
        }
    }
}