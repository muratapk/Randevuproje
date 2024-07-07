using denemproje.Data;
using denemproje.Models;
using Microsoft.AspNetCore.Mvc;

namespace denemproje.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin gelen)
        {
            if(ModelState.IsValid)
            {
                var kontrol = _context.Admins.Where(x => x.UserName == gelen.UserName && x.PassWord == gelen.PassWord).FirstOrDefault();
                if (kontrol != null)
                {
                    return RedirectToAction("Index", "Admins");
                }
            }
            
            return RedirectToAction("Index");
        }
    }
}
