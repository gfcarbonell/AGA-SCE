using sce_aga_server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;
using System.Web.Mvc;

namespace sce_aga_server.Controllers
{
    public class SCEPersonaEncargadoController : Controller
    {
        // GET: SCEPersonaEncargado
        [HttpGet]
        public JsonResult Index()
        {
            Response.AppendHeader("Access-Control-Allow-Origin", "*");

            var obj = new List<SCEEncargado>();
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}