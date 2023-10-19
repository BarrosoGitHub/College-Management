namespace CollegeManagement.Models;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string RegistrationNumber { get; set; }
    public ICollection<Subject> Subjects { get; set; } = null!;
    public ICollection<Grade> Grades { get; set; } = null!;
}