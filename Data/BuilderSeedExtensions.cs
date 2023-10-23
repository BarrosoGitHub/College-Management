using CollegeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Data;


public static class BuilderSeedExtensions
{
    public static void SeedCourse(this ModelBuilder builder)
    {
        builder.Entity<Course>().HasData(
            new Course
            {
                Id = 1,
                Name = "Electrical Engineering"

            },
            new Course
            {
                Id = 2,
                Name = "Computer Science"
            },
            new Course
            {
                Id = 3,
                Name = "Mechanical Engineering"
            },
            new Course
            {
                Id = 4,
                Name = "Civil Engineering"
            },
            new Course
            {
                Id = 5,
                Name = "Chemical Engineering"
            }
        );
    }

    public static void SeedSubjects(this ModelBuilder builder)
    {
        builder.Entity<Subject>().HasData(
            new Subject
            {
                Id = 1,
                Name = "Mathematics",
                ProfessorId = 10,
            },
            new Subject
            {
                Id = 2,
                Name = "Physics",
                ProfessorId = 2,
            },
            new Subject
            {
                Id = 3,
                Name = "Computer Science",
                ProfessorId = 1,
            },
            new Subject
            {
                Id = 4,
                Name = "Mechanics",
                ProfessorId = 3,
            },
            new Subject
            {
                Id = 5,
                Name = "Chemistry",
                ProfessorId = 6,
            },
            new Subject
            {
                Id = 6,
                Name = "Logic Systems",
                ProfessorId = 7,
            },
            new Subject
            {
                Id = 7,
                Name = "Termodynamics",
                ProfessorId = 8,
            },
            new Subject
            {
                Id = 8,
                Name = "Economy",
                ProfessorId = 9,
            },
            new Subject
            {
                Id = 9,
                Name = "Probability",
                ProfessorId = 4,
            },
            new Subject
            {
                Id = 10,
                Name = "Programming",
                ProfessorId = 5,
            }
        );
    }

    public static void SeedProfessors(this ModelBuilder builder)
    {
        builder.Entity<Professor>().HasData(
            new Professor
            {
                Id = 1,
                Name = "John Smith",
                Age = 40,
                Salary = 5000
            },
            new Professor
            {
                Id = 2,
                Name = "Emily Johnson",
                Age = 45,
                Salary = 5500
            },
            new Professor
            {
                Id = 3,
                Name = "Michael Williams",
                Age = 38,
                Salary = 4800
            },
            new Professor
            {
                Id = 4,
                Name = "Jessica Brown",
                Age = 50,
                Salary = 6000
            },
            new Professor
            {
                Id = 5,
                Name = "Daniel Miller",
                Age = 42,
                Salary = 5200
            },
            new Professor
            {
                Id = 6,
                Name = "Olivia Davis",
                Age = 36,
                Salary = 4700
            },
            new Professor
            {
                Id = 7,
                Name = "David Garcia",
                Age = 48,
                Salary = 5800
            },
            new Professor
            {
                Id = 8,
                Name = "Sophia Wilson",
                Age = 44,
                Salary = 5300
            },
            new Professor
            {
                Id = 9,
                Name = "Joseph Taylor",
                Age = 39,
                Salary = 4900
            },
            new Professor
            {
                Id = 10,
                Name = "Emma Anderson",
                Age = 37,
                Salary = 4600
            }
        );

    }

    public static void SeedCourseSubject(this ModelBuilder builder)
    {
        builder.Entity<CourseSubject>().HasData(
        new CourseSubject { CourseId = 1, SubjectId = 1 },
        new CourseSubject { CourseId = 1, SubjectId = 2 },
        new CourseSubject { CourseId = 1, SubjectId = 6 },
        new CourseSubject { CourseId = 2, SubjectId = 3 },
        new CourseSubject { CourseId = 2, SubjectId = 5 },
        new CourseSubject { CourseId = 2, SubjectId = 6 },
        new CourseSubject { CourseId = 3, SubjectId = 1 },
        new CourseSubject { CourseId = 3, SubjectId = 4 },
        new CourseSubject { CourseId = 3, SubjectId = 7 },
        new CourseSubject { CourseId = 4, SubjectId = 8 },
        new CourseSubject { CourseId = 4, SubjectId = 6 },
        new CourseSubject { CourseId = 4, SubjectId = 4 },
        new CourseSubject { CourseId = 5, SubjectId = 5 },
        new CourseSubject { CourseId = 5, SubjectId = 7 },
        new CourseSubject { CourseId = 5, SubjectId = 9 }
        // Add more CourseSubject entities to customize the relationships
    );
    }

    public static void SeedStudents(this ModelBuilder builder)
    {
        var students = new List<Student>();
        var random = new Random();

        for (int i = 1; i <= 50; i++)
        {
            students.Add(new Student
            {
                Id = i,
                Name = $"Student {i}",
                Age = random.Next(18, 25), // Random age between 18 and 25
                RegistrationNumber = $"REG{i:D3}", // Registration number with leading zeros
                CourseId = random.Next(1, 6)// Random course id between 1 and 5
            });
        }

        builder.Entity<Student>().HasData(students);
    }
}

