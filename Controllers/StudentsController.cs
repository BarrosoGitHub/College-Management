using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CollegeManagement.Data;
using CollegeManagement.Models;

namespace CollegeManagement.Controllers
{
    public class StudentsController : Controller
    {
        private readonly CollegeManagementContext _context;

        public StudentsController(CollegeManagementContext context)
        {
            _context = context;
        }

        // GET: Students
        public IActionResult Index(int? courseId, int? subjectId)
        {
            var students = _context.Students.AsQueryable();

            if (courseId != null && subjectId != null)
            {
                students = students.Where(s => s.CourseId == courseId);
            }
            else if (courseId != null)
            {
                students = students.Where(s => s.CourseId == courseId);
            }

            return View(students.ToList());
        }

        // GET: Students/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

        // GET: Students/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                return NotFound();
            }

            _context.Students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
