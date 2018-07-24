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
    public class SCETerminalServicio : ISCETerminal
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

        public ICollection<SCETerminal> Get()
        {
            List<SCETerminal> terminales = new List<SCETerminal>();
            try
            {
                DbCommand cmd;
                cmd = objDB.GetStoredProcCommand(Esquema + ".[PR_SCE_TERMINAL_QRY]");
                foreach (DataRow dr in objDB.ExecuteDataSet(cmd).Tables[0].Rows)
                {
                    SCETerminal pr = new SCETerminal();
                    pr.IdTerminal = dr[0].ToString();
                    pr.Descripcion = dr[1].ToString();
                    terminales.Add(pr);
                }
            }
            catch (Exception e)
            {
                terminales = null;
            }
            return terminales;
        }

        public SCETerminal Save(SCETerminal entidad)
        {
            throw new NotImplementedException();
        }

        public SCETerminal Update(SCETerminal entidad)
        {
            throw new NotImplementedException();
        }
    }
}