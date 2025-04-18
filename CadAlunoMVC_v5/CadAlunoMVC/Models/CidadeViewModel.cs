using Microsoft.AspNetCore.Mvc;

namespace CadAlunoMVC.Models
{
    public class CidadeViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
