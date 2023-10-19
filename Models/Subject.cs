using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Models;

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
    public ICollection<Student> Students { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
}