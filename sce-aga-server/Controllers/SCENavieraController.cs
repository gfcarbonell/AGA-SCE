using sce_aga_server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sce_aga_server.Controllers
{
    public class SCENavieraController : Controller
    {
        // GET: SCENaviera
        [HttpGet]
        public JsonResult Index()
        {
            SCENavieraServicio serv = new SCENavieraServicio();
            return Json(serv.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}