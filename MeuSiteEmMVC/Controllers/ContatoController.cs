using Microsoft.AspNetCore.Mvc;

namespace MeuSiteEmMVC.Controllers {
    public class ContatoController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
