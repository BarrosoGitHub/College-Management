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
            },
            new Subject
            {
                Id = 2,
                Name = "Physics",
            },
            new Subject
            {
                Id = 3,
                Name = "Computer Science",
            },
            new Subject
            {
                Id = 4,
                Name = "Mechanics",
            },
            new Subject
            {
                Id = 5,
                Name = "Chemistry",
            },
            new Subject
            {
                Id = 6,
                Name = "Logic Systems",
            },
            new Subject
            {
                Id = 7,
                Name = "Termodynamics",
            },
            new Subject
            {
                Id = 8,
                Name = "Economy",
            },
            new Subject
            {
                Id = 9,
                Name = "Probability",
            },
            new Subject
            {
                Id = 10,
                Name = "Programming",
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
}

