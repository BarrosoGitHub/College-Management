using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CollegeManagement.Data;
using CollegeManagement.Models;

namespace CollegeManagement.Controllers
{
    public class SubjectsController : Controller
    {
        private readonly CollegeManagementContext _context;

        public SubjectsController(CollegeManagementContext context)
        {
            _context = context;
        }

        // GET: Subjects
        public IActionResult Index()
        {
            return View(_context.Subjects.Include(s => s.Professor).Include(s => s.Students).Include(s => s.Courses).ToList());
        }

        // GET: Subjects/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var subject = _context.Subjects
                .Include(s => s.Professor)
                .Include(s => s.Students)
                .Include(s => s.Courses)
                .FirstOrDefault(m => m.Id == id);

            if (subject == null)
            {
                return NotFound();
            }

            return View(subject);
        }

        // Other CRUD actions...

        private bool SubjectExists(int id)
        {
            return _context.Subjects.Any(e => e.Id == id);
        }
    }
}