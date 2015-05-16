using System.Web.Mvc;
using Repositorio;

namespace Partitu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Endereco endereco = new Endereco();
            endereco.bairro = "my endereco";
            endereco.cidade = "My Cidade";

            Usuario usuario = (Usuario)Session["usuario"];
            ViewBag.nomeUser = usuario!=null ? usuario.nome : null;
            return View(endereco);
        }


       

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
