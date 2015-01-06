using CraftingPoE.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CraftingPoE.Controllers
{
    public class HomeController : Controller
    {
        private ICraftingRepo _craftingRepo;

        public HomeController(ICraftingRepo craftingRepo)
        {
            _craftingRepo = craftingRepo;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var mods = _craftingRepo.GetItemType(1);
            return View();
        }
    }
}
