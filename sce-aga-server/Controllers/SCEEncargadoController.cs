using sce_aga_server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sce_aga_server.Controllers
{
    public class SCEEncargadoController : Controller
    {
        // GET: SCEEncargado
        public JsonResult Index()
        {
            SCEEncargadoServicio serv = new SCEEncargadoServicio();
            return Json(serv.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}