using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Models;

public class Professor
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public decimal Salary { get; set; }
    public ICollection<Subject> Subjects { get; set; }
}