namespace src.api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new RedirectResult("~/swagger/");
        }


    }
}