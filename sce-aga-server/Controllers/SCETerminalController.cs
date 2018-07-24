using sce_aga_server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sce_aga_server.Controllers
{
    public class SCETerminalController : Controller
    {
        // GET: SCETerminal
        [HttpGet]
        public JsonResult Index()
        {
            SCETerminalServicio serv = new SCETerminalServicio();
            return Json(serv.Get(), JsonRequestBehavior.AllowGet);
        }
    }
}