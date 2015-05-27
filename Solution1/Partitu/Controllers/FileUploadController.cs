using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Partitu.Controllers
{
    public class FileUploadController : Controller
    {
        //
        // GET: /FileUpload/




        public ActionResult FileUpload() { return View(); }

        [HttpPost]
        public ActionResult FileUpload(HttpPostedFileBase file)
        {

            
              //Suas validações ...... VEN
                //Salva o arquivo
            if (file.ContentLength > 0)
                {
                    string caminhoArquivo = Path.Combine(Server.MapPath("~/Images/vendedor"), Path.GetFileName(file.FileName));
                    file.SaveAs(caminhoArquivo);  
                } 
                
            return View(); 
        }


        public string salvarFoto(HttpPostedFile file, string salt)
        {
            string combinacao = salt + Path.GetFileName(file.FileName);
            string caminhoArquivo = Path.Combine(Server.MapPath("~/Images/vendedor"), combinacao);
            file.SaveAs(caminhoArquivo);
            return caminhoArquivo; 
        }

    }
}
