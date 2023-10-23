namespace CollegeManagement.Models;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string RegistrationNumber { get; set; }
    public decimal CourseAverage { get; set; } = 0;
    public int? CourseId { get; set; }
    public Course Course { get; set; }
    public ICollection<Grade> Grades { get; set; } = null!;
    
}