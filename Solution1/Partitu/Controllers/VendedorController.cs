using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Partitu.Models;
using System.IO;

namespace Partitu.Controllers
{
    public class VendedorController : Controller
    {
        //
        // GET: /Vendedor/

        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(VendedorModel vendedor)

        {
            return View(vendedor);
        }

    }
}
