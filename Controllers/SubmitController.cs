using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Words_from_Strangers.Models;

namespace Words_from_Strangers.Controllers
{
    public class SubmitController : Controller
    {
        private MessageContext _context { get; set; }

        public SubmitController(MessageContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Submit Message
        [HttpGet]
        public IActionResult Submit()
        {

            return View("Submit", new Message());
        }

        [HttpPost]
        public IActionResult Submit(Message _message)
        {
            if (ModelState.IsValid)
            {
                _context.Messages.Add(_message);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
