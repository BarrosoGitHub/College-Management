﻿// <auto-generated />
using System;
using CollegeManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CollegeManagement.Migrations
{
    [DbContext(typeof(CollegeManagementContext))]
    [Migration("20231023133840_AddedFakeNames")]
    partial class AddedFakeNames
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CollegeManagement.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Electrical Engineering"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Computer Science"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Mechanical Engineering"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Civil Engineering"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chemical Engineering"
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.CourseSubject", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("CourseId", "SubjectId");

                    b.HasIndex("SubjectId");

                    b.ToTable("CourseSubjects");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            SubjectId = 1
                        },
                        new
                        {
                            CourseId = 1,
                            SubjectId = 2
                        },
                        new
                        {
                            CourseId = 1,
                            SubjectId = 6
                        },
                        new
                        {
                            CourseId = 2,
                            SubjectId = 3
                        },
                        new
                        {
                            CourseId = 2,
                            SubjectId = 5
                        },
                        new
                        {
                            CourseId = 2,
                            SubjectId = 6
                        },
                        new
                        {
                            CourseId = 3,
                            SubjectId = 1
                        },
                        new
                        {
                            CourseId = 3,
                            SubjectId = 4
                        },
                        new
                        {
                            CourseId = 3,
                            SubjectId = 7
                        },
                        new
                        {
                            CourseId = 4,
                            SubjectId = 8
                        },
                        new
                        {
                            CourseId = 4,
                            SubjectId = 6
                        },
                        new
                        {
                            CourseId = 4,
                            SubjectId = 4
                        },
                        new
                        {
                            CourseId = 5,
                            SubjectId = 5
                        },
                        new
                        {
                            CourseId = 5,
                            SubjectId = 7
                        },
                        new
                        {
                            CourseId = 5,
                            SubjectId = 9
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Grades");
                });

            modelBuilder.Entity("CollegeManagement.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Professors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 40,
                            Name = "John Smith",
                            Salary = 5000m
                        },
                        new
                        {
                            Id = 2,
                            Age = 45,
                            Name = "Emily Johnson",
                            Salary = 5500m
                        },
                        new
                        {
                            Id = 3,
                            Age = 38,
                            Name = "Michael Williams",
                            Salary = 4800m
                        },
                        new
                        {
                            Id = 4,
                            Age = 50,
                            Name = "Jessica Brown",
                            Salary = 6000m
                        },
                        new
                        {
                            Id = 5,
                            Age = 42,
                            Name = "Daniel Miller",
                            Salary = 5200m
                        },
                        new
                        {
                            Id = 6,
                            Age = 36,
                            Name = "Olivia Davis",
                            Salary = 4700m
                        },
                        new
                        {
                            Id = 7,
                            Age = 48,
                            Name = "David Garcia",
                            Salary = 5800m
                        },
                        new
                        {
                            Id = 8,
                            Age = 44,
                            Name = "Sophia Wilson",
                            Salary = 5300m
                        },
                        new
                        {
                            Id = 9,
                            Age = 39,
                            Name = "Joseph Taylor",
                            Salary = 4900m
                        },
                        new
                        {
                            Id = 10,
                            Age = 37,
                            Name = "Emma Anderson",
                            Salary = 4600m
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int?>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegistrationNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 20,
                            CourseId = 2,
                            Name = "Yesenia Konopelski",
                            RegistrationNumber = "REG001"
                        },
                        new
                        {
                            Id = 2,
                            Age = 24,
                            CourseId = 2,
                            Name = "Mr. Willy Pfeffer",
                            RegistrationNumber = "REG002"
                        },
                        new
                        {
                            Id = 3,
                            Age = 23,
                            CourseId = 1,
                            Name = "Prof. Kelsie Kirlin",
                            RegistrationNumber = "REG003"
                        },
                        new
                        {
                            Id = 4,
                            Age = 18,
                            CourseId = 3,
                            Name = "Ms. Avis Murray I",
                            RegistrationNumber = "REG004"
                        },
                        new
                        {
                            Id = 5,
                            Age = 24,
                            CourseId = 2,
                            Name = "Mrs. Derrick O'Keefe",
                            RegistrationNumber = "REG005"
                        },
                        new
                        {
                            Id = 6,
                            Age = 18,
                            CourseId = 5,
                            Name = "Ethan Bartoletti III",
                            RegistrationNumber = "REG006"
                        },
                        new
                        {
                            Id = 7,
                            Age = 18,
                            CourseId = 3,
                            Name = "Matt Swift",
                            RegistrationNumber = "REG007"
                        },
                        new
                        {
                            Id = 8,
                            Age = 21,
                            CourseId = 2,
                            Name = "Elissa Wolf",
                            RegistrationNumber = "REG008"
                        },
                        new
                        {
                            Id = 9,
                            Age = 23,
                            CourseId = 2,
                            Name = "Verner Bruen",
                            RegistrationNumber = "REG009"
                        },
                        new
                        {
                            Id = 10,
                            Age = 19,
                            CourseId = 3,
                            Name = "Matteo Smitham",
                            RegistrationNumber = "REG010"
                        },
                        new
                        {
                            Id = 11,
                            Age = 20,
                            CourseId = 4,
                            Name = "Dr. Jevon Bradtke Jr.",
                            RegistrationNumber = "REG011"
                        },
                        new
                        {
                            Id = 12,
                            Age = 18,
                            CourseId = 2,
                            Name = "Lucie Wilfredo Greenfelder V",
                            RegistrationNumber = "REG012"
                        },
                        new
                        {
                            Id = 13,
                            Age = 24,
                            CourseId = 5,
                            Name = "Ms. Aiyana Katelin Beatty III",
                            RegistrationNumber = "REG013"
                        },
                        new
                        {
                            Id = 14,
                            Age = 19,
                            CourseId = 3,
                            Name = "Prof. Terence Homenick DVM",
                            RegistrationNumber = "REG014"
                        },
                        new
                        {
                            Id = 15,
                            Age = 19,
                            CourseId = 2,
                            Name = "Osvaldo Kiehn",
                            RegistrationNumber = "REG015"
                        },
                        new
                        {
                            Id = 16,
                            Age = 21,
                            CourseId = 2,
                            Name = "Abbigail Johnson",
                            RegistrationNumber = "REG016"
                        },
                        new
                        {
                            Id = 17,
                            Age = 20,
                            CourseId = 4,
                            Name = "Toni Johnston",
                            RegistrationNumber = "REG017"
                        },
                        new
                        {
                            Id = 18,
                            Age = 20,
                            CourseId = 2,
                            Name = "Miss Ezequiel Legros Sr.",
                            RegistrationNumber = "REG018"
                        },
                        new
                        {
                            Id = 19,
                            Age = 19,
                            CourseId = 4,
                            Name = "Magdalen Ziemann",
                            RegistrationNumber = "REG019"
                        },
                        new
                        {
                            Id = 20,
                            Age = 22,
                            CourseId = 2,
                            Name = "Mr. Violet Wisozk MD",
                            RegistrationNumber = "REG020"
                        },
                        new
                        {
                            Id = 21,
                            Age = 19,
                            CourseId = 5,
                            Name = "Aracely Schowalter",
                            RegistrationNumber = "REG021"
                        },
                        new
                        {
                            Id = 22,
                            Age = 22,
                            CourseId = 3,
                            Name = "Gerhard Gorczany",
                            RegistrationNumber = "REG022"
                        },
                        new
                        {
                            Id = 23,
                            Age = 23,
                            CourseId = 1,
                            Name = "Kenna Goyette",
                            RegistrationNumber = "REG023"
                        },
                        new
                        {
                            Id = 24,
                            Age = 23,
                            CourseId = 5,
                            Name = "Dr. Ralph Schinner",
                            RegistrationNumber = "REG024"
                        },
                        new
                        {
                            Id = 25,
                            Age = 19,
                            CourseId = 3,
                            Name = "Henri Denesik",
                            RegistrationNumber = "REG025"
                        },
                        new
                        {
                            Id = 26,
                            Age = 24,
                            CourseId = 2,
                            Name = "Lavern Kling",
                            RegistrationNumber = "REG026"
                        },
                        new
                        {
                            Id = 27,
                            Age = 20,
                            CourseId = 5,
                            Name = "Heidi Olson",
                            RegistrationNumber = "REG027"
                        },
                        new
                        {
                            Id = 28,
                            Age = 23,
                            CourseId = 1,
                            Name = "Bulah Batz DDS",
                            RegistrationNumber = "REG028"
                        },
                        new
                        {
                            Id = 29,
                            Age = 21,
                            CourseId = 5,
                            Name = "Emory Bosco",
                            RegistrationNumber = "REG029"
                        },
                        new
                        {
                            Id = 30,
                            Age = 23,
                            CourseId = 1,
                            Name = "Maud Streich V",
                            RegistrationNumber = "REG030"
                        },
                        new
                        {
                            Id = 31,
                            Age = 19,
                            CourseId = 5,
                            Name = "Marguerite Kihn",
                            RegistrationNumber = "REG031"
                        },
                        new
                        {
                            Id = 32,
                            Age = 20,
                            CourseId = 4,
                            Name = "Kaia Carson Ortiz II",
                            RegistrationNumber = "REG032"
                        },
                        new
                        {
                            Id = 33,
                            Age = 19,
                            CourseId = 3,
                            Name = "Prof. Antwon Gus Hessel",
                            RegistrationNumber = "REG033"
                        },
                        new
                        {
                            Id = 34,
                            Age = 24,
                            CourseId = 2,
                            Name = "Ms. Baylee Priscilla Ondricka II",
                            RegistrationNumber = "REG034"
                        },
                        new
                        {
                            Id = 35,
                            Age = 23,
                            CourseId = 3,
                            Name = "Ms. Ed Adalberto Jacobson",
                            RegistrationNumber = "REG035"
                        },
                        new
                        {
                            Id = 36,
                            Age = 22,
                            CourseId = 1,
                            Name = "Lavada Crist",
                            RegistrationNumber = "REG036"
                        },
                        new
                        {
                            Id = 37,
                            Age = 23,
                            CourseId = 3,
                            Name = "Bell Nolan",
                            RegistrationNumber = "REG037"
                        },
                        new
                        {
                            Id = 38,
                            Age = 23,
                            CourseId = 5,
                            Name = "Antwon Graham MD",
                            RegistrationNumber = "REG038"
                        },
                        new
                        {
                            Id = 39,
                            Age = 19,
                            CourseId = 2,
                            Name = "Larry Johnston",
                            RegistrationNumber = "REG039"
                        },
                        new
                        {
                            Id = 40,
                            Age = 21,
                            CourseId = 4,
                            Name = "Antonetta Schinner",
                            RegistrationNumber = "REG040"
                        },
                        new
                        {
                            Id = 41,
                            Age = 20,
                            CourseId = 5,
                            Name = "Prof. Araceli Major Hoeger II",
                            RegistrationNumber = "REG041"
                        },
                        new
                        {
                            Id = 42,
                            Age = 24,
                            CourseId = 4,
                            Name = "Prof. Adonis Kerluke",
                            RegistrationNumber = "REG042"
                        },
                        new
                        {
                            Id = 43,
                            Age = 20,
                            CourseId = 2,
                            Name = "Dr. Burley Cayla Bauch IV",
                            RegistrationNumber = "REG043"
                        },
                        new
                        {
                            Id = 44,
                            Age = 20,
                            CourseId = 4,
                            Name = "Ms. Estefania Macejkovic",
                            RegistrationNumber = "REG044"
                        },
                        new
                        {
                            Id = 45,
                            Age = 18,
                            CourseId = 5,
                            Name = "Miss Chandler Chris Leannon III",
                            RegistrationNumber = "REG045"
                        },
                        new
                        {
                            Id = 46,
                            Age = 21,
                            CourseId = 1,
                            Name = "Prof. Madonna Mary Hartmann",
                            RegistrationNumber = "REG046"
                        },
                        new
                        {
                            Id = 47,
                            Age = 18,
                            CourseId = 1,
                            Name = "Cierra Welch",
                            RegistrationNumber = "REG047"
                        },
                        new
                        {
                            Id = 48,
                            Age = 20,
                            CourseId = 3,
                            Name = "Miss Olin Crona MD",
                            RegistrationNumber = "REG048"
                        },
                        new
                        {
                            Id = 49,
                            Age = 23,
                            CourseId = 3,
                            Name = "Zella Sporer",
                            RegistrationNumber = "REG049"
                        },
                        new
                        {
                            Id = 50,
                            Age = 23,
                            CourseId = 5,
                            Name = "Ms. Jacinto Mossie Schroeder IV",
                            RegistrationNumber = "REG050"
                        });
                });

            modelBuilder.Entity("CollegeManagement.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mathematics",
                            ProfessorId = 10
                        },
                        new
                        {
                            Id = 2,
                            Name = "Physics",
                            ProfessorId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Computer Science",
                            ProfessorId = 1
                        },
                        new
                        {
                            Id = 4,
                            Name = "Mechanics",
                            ProfessorId = 3
                        },
                        new
                        {
                            Id = 5,
                            Name = "Chemistry",
                            ProfessorId = 6
                        },
                        new
                        {
                            Id = 6,
                            Name = "Logic Systems",
                            ProfessorId = 7
                        },
                        new
                        {
                            Id = 7,
                            Name = "Termodynamics",
                            ProfessorId = 8
                        },
                        new
                        {
                            Id = 8,
                            Name = "Economy",
                            ProfessorId = 9
                        },
                        new
                        {
                            Id = 9,
                            Name = "Probability",
                            ProfessorId = 4
                        },
                        new
                        {
                            Id = 10,
                            Name = "Programming",
                            ProfessorId = 5
                        });
                });

            modelBuilder.Entity("CourseSubject", b =>
                {
                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("CourseSubject");
                });

            modelBuilder.Entity("CollegeManagement.Models.CourseSubject", b =>
                {
                    b.HasOne("CollegeManagement.Models.Course", "Course")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", "Subject")
                        .WithMany("CourseSubjects")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("CollegeManagement.Models.Grade", b =>
                {
                    b.HasOne("CollegeManagement.Models.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("CollegeManagement.Models.Student", b =>
                {
                    b.HasOne("CollegeManagement.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId");

                    b.HasOne("CollegeManagement.Models.Subject", null)
                        .WithMany("Students")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("CollegeManagement.Models.Subject", b =>
                {
                    b.HasOne("CollegeManagement.Models.Professor", "Professor")
                        .WithMany("Subjects")
                        .HasForeignKey("ProfessorId");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("CourseSubject", b =>
                {
                    b.HasOne("CollegeManagement.Models.Course", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CollegeManagement.Models.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CollegeManagement.Models.Course", b =>
                {
                    b.Navigation("CourseSubjects");
                });

            modelBuilder.Entity("CollegeManagement.Models.Professor", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("CollegeManagement.Models.Student", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("CollegeManagement.Models.Subject", b =>
                {
                    b.Navigation("CourseSubjects");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
