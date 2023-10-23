using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Data;
using CollegeManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace CollegeManagement.Controllers
{
    public class GradesController : Controller
    {
        private readonly CollegeManagementContext _context;

        public GradesController(CollegeManagementContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            ViewBag.Subjects = _context.Subjects.ToList();
            ViewBag.Students = _context.Students.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Grade grade)
        {

            _context.Grades.Add(grade);
            _context.SaveChanges();
            return RedirectToAction("Create");


            return View(grade);
        }
    }
}