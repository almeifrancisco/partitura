using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositorio;
using Partitu.Models;
using Service.service;
using System.IO;
namespace Partitu.Controllers
{
    public class PartituraController : Controller
    {
        //
        // GET: /Partitura/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PartituraCadastrar( )
        {
           PartituraModel parti = new PartituraModel(); 
            return View(parti); 
        } 

        [Authorize]
        [HttpPost]
        public ActionResult PartituraCadastrar(PartituraModel model, HttpPostedFileBase file)
        {
            
                    Usuario user = (Usuario)Session["usuario"];

            if (ModelState.IsValid)
            {
                try
                {
                    try
                    {
                        if (file.ContentLength > 0) 
                        { 
                            string url = Path.Combine(Server.MapPath("~/Images/partituras"), Path.GetFileName(file.FileName));
                            file.SaveAs(url);
                        } 
                    }

                    catch
                    {
                        ViewBag.msg = "Arquivo não enviado, tente novamente. Caso não esteja conseguindo entre em contato com a administração.";
                        return View();
                    }
                    model.fk_vendedor = user.id; 
                    Partitura partitura = troca(model);
                    PartituraService serv = new PartituraService();
                    serv.Insert(partitura);
                    return RedirectToAction("Index", "Home");

                }catch
                {
                    
                    ViewBag.msg = "Não foi possível cadastra, entre em contato com a administrãção.";
                    return View(model); 
                } 

            } 


            return View();
        }


        private Partitura troca(PartituraModel model)
        {
            Partitura partitura = new Partitura()
            {
                arranjo_trancricao = model.transcricao,
                artista = model.artista,
                descricao = model.descricao,
                instrumentos = model.instrumentos,
                musica = model.musica,
                nome = model.nome,
                preco = model.preco,
                fk_vendedor = model.fk_vendedor,
                disponivel = model.disponivel,

            };
            return partitura;
            
        } 
    }
}
