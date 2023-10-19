namespace CollegeManagement.Models;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string RegistrationNumber { get; set; }
    public ICollection<Subject> Subjects { get; set; }
    public ICollection<Grade> Grades { get; set; }
}