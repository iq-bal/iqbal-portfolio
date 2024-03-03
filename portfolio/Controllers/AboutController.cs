using Microsoft.AspNetCore.Mvc;
using portfolio.Data;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class AboutController : Controller
    {
        private ApplicationDbContext _db;
        public AboutController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            About aboutRecord = _db.About.FirstOrDefault();
            return View(aboutRecord);
        }
    }
}
