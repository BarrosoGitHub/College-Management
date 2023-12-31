using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollegeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Data;

public class CollegeManagementContext : DbContext
{

    public DbSet<Course> Courses { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Professor> Professors { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Grade> Grades { get; set; }
    public DbSet<CourseSubject> CourseSubjects { get; set; }

    public CollegeManagementContext() {}
    public CollegeManagementContext(DbContextOptions<CollegeManagementContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<CourseSubject>()
        .HasKey(cs => new { cs.CourseId, cs.SubjectId });

    modelBuilder.Entity<CourseSubject>()
        .HasOne(cs => cs.Course)
        .WithMany(c => c.CourseSubjects)
        .HasForeignKey(cs => cs.CourseId);

    modelBuilder.Entity<CourseSubject>()
        .HasOne(cs => cs.Subject)
        .WithMany(s => s.CourseSubjects)
        .HasForeignKey(cs => cs.SubjectId);

        // modelBuilder.Entity<Course>()
        // .HasMany(c => c.Subjects)
        // .WithMany(s => s.Courses)
        // .UsingEntity(j => j.ToTable("CourseSubjects"));

        // // Configure the relationships between entities
        // modelBuilder.Entity<Course>()
        //     .HasMany(c => c.Subjects);

        // modelBuilder.Entity<Subject>()
        //     .HasOne(s => s.Professor)
        //     .WithMany(p => p.Subjects)
        //     .HasForeignKey(s => s.ProfessorId);

        // modelBuilder.Entity<Student>()
        //     .HasMany(s => s.Subjects)
        //     .WithMany(s => s.Students)
        //     .UsingEntity<Dictionary<string, object>>(
        //         "StudentSubject",
        //         j => j.HasOne<Subject>().WithMany().HasForeignKey("SubjectId"),
        //         j => j.HasOne<Student>().WithMany().HasForeignKey("StudentId"),
        //         j =>
        //         {
        //             j.Property<int>("Id");
        //             j.HasKey("Id");
        //         });

        // modelBuilder.Entity<Grade>()
        //     .HasOne(g => g.Subject)
        //     .WithMany()
        //     .HasForeignKey(g => g.SubjectId);

        // modelBuilder.Entity<Grade>()
        //     .HasOne(g => g.Student)
        //     .WithMany()
        //     .HasForeignKey(g => g.StudentId);

        modelBuilder.SeedCourse();
        modelBuilder.SeedSubjects();
        modelBuilder.SeedProfessors();
        modelBuilder.SeedCourseSubject();
        modelBuilder.SeedStudents();
    }
}