using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CollegeManagement.Models;

public class Grade
{
    public int Id { get; set; }
    public int SubjectId { get; set; }
    public int StudentId { get; set; }
    public decimal Value { get; set; }
    public Subject Subject { get; set; } 
    public Student Student { get; set; }
    
}