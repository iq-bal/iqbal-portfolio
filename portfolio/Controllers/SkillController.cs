using Microsoft.AspNetCore.Mvc;
using portfolio.Data;
using portfolio.Models;

namespace portfolio.Controllers
{
    public class SkillController : Controller
    {
        private ApplicationDbContext _db;
        public SkillController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Skill> skillList = _db.Skills.ToList();
            return View(skillList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Skill obj)
        {
            if (ModelState.IsValid)
            {
                _db.Skills.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            List<Skill> skillList = _db.Skills.ToList();
            return View(skillList);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Skill categoryFromDb = _db.Skills.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        public IActionResult Edit(Skill obj)
        {
            if (ModelState.IsValid)
            {
                _db.Skills.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Skill categoryFromDb = _db.Skills.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int id)
        {
            Skill obj = _db.Skills.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            _db.Skills.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

            if (ModelState.IsValid)
            {
                _db.Skills.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
