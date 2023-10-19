using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Models;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Subject> Subjects { get; set; } = null!;
    public ICollection<CourseSubject> CourseSubjects { get; set; } = null!;
}