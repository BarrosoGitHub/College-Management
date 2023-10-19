using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Data;
using CollegeManagement.Models;

namespace CollegeManagement.Controllers
{
    public class ProfessorsController : Controller
    {
        private readonly CollegeManagementContext _context;

        public ProfessorsController(CollegeManagementContext context)
        {
            _context = context;
        }

        // GET: Professors
        public IActionResult Index()
        {
            var professors = _context.Professors.ToList();
            return View(professors);
        }

        // GET: Professors/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = _context.Professors.FirstOrDefault(p => p.Id == id);

            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // GET: Professors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Professors/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Professor professor)
        {
            if (ModelState.IsValid)
            {
                _context.Professors.Add(professor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(professor);
        }

        // GET: Professors/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = _context.Professors.FirstOrDefault(p => p.Id == id);

            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // POST: Professors/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Professor professor)
        {
            if (id != professor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Professors.Update(professor);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(professor);
        }

        // GET: Professors/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var professor = _context.Professors.FirstOrDefault(p => p.Id == id);

            if (professor == null)
            {
                return NotFound();
            }

            return View(professor);
        }

        // POST: Professors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var professor = _context.Professors.FirstOrDefault(p => p.Id == id);

            if (professor == null)
            {
                return NotFound();
            }

            _context.Professors.Remove(professor);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}