using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.service;
using Partitu.Models;
using Service.service.seguranca;
using Repositorio;
using System.Web.Security;
namespace Partitu.Controllers
{
    public class AcessoController : Controller
    {
        //
        // GET: /Acesso/

        public ActionResult Login()
        {
            UsuarioModel usuario = new UsuarioModel();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Login(UsuarioModel model, string returnUrl)
        {

            PasswordManager pswMng = new PasswordManager();
            
            UsuarioService serv = new UsuarioService();

            Usuario usuario = serv.getPorEmail(model.email);
            if (usuario == null)
            {
                ModelState.AddModelError("email", "usuario não encontrado.");


            }
            else
            {
                if (pswMng.IsPasswordMatch(model.senha, usuario.codS, usuario.senha))
                {
                    Session["usuario"] = usuario; ;
                    FormsAuthentication.SetAuthCookie(usuario.email, false);
                    return RedirectToAction("index", "home");
                }
                else
                {
                    ModelState.AddModelError("email", "Usuario ou senha incorreto");
                }
            }

           
            
           

           return View(model);
        
       }

        public ActionResult Logout()
        {
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("index", "home");
        }
    }
}
