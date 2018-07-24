using sce_aga_server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sce_aga_server.Controllers
{
    public class SCEOperadorLogisticoController : Controller
    {
        // GET: SCEOperadorLogistico
        [HttpGet]
        public JsonResult Index()
        {
            SCEOperadorLogisticoServicio serv = new SCEOperadorLogisticoServicio();
            return Json(serv.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}