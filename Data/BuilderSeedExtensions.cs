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
}

