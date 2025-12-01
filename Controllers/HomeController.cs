using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Words_from_Strangers.Models;

namespace Words_from_Strangers.Controllers
{
    public class HomeController : Controller
    {
        private readonly MessageContext _context;

        public HomeController(MessageContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            var randomMessages = _context.Messages
                .OrderBy(m => Guid.NewGuid())
                .Take(5).ToList();

            return View(randomMessages);
        }

        public IActionResult About()
        {
            return View("About");
        }
    }
}
