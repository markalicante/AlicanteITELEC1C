using Microsoft.EntityFrameworkCore;
using System;
using AlicanteITELEC1C.Models;

namespace AlicanteITELEC1C.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //Data Seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                 new Student()
                 {
                     Id = 1,
                     FirstName = "Gabriel",
                     LastName = "Montano",
                     Course = Course.BSIT,
                     AdmissionDate = DateTime.Parse("2022-08-26"),
                     GPA = 1.5,
                     Email = "ghaby021@gmail.com",
                     PhoneNumber = "0998-767-3671"
                 },
                new Student()
                {
                    Id = 2,
                    FirstName = "Zyx",
                    LastName = "Montano",
                    Course = Course.BSIS,
                    AdmissionDate = DateTime.Parse("2022-08-07"),
                    GPA = 1,
                    Email = "zyx@gmail.com",
                    PhoneNumber = "0954-234-4511"
                },
                new Student()
                {
                    Id = 3,
                    FirstName = "Aerdriel",
                    LastName = "Montano",
                    Course = Course.BSCS,
                    AdmissionDate = DateTime.Parse("2020-01-25"),
                    GPA = 1.5,
                    Email = "aerdriel@gmail.com",
                    PhoneNumber = "0912-745-7851"
                }
                );


            modelBuilder.Entity<Instructor>().HasData(
                 new Instructor()
                 {
                     InstructorId = 1,
                     InsFirst = "Gabriel",
                     InsLast = "Montano",
                     HiringDate = DateTime.Parse("2022-08-26"),
                     IsTenured = false,
                     InstructorRank = Rank.Instructor,
                     PhoneNumber = "0998-767-3671"
                 },
                new Instructor()
                {
                    InstructorId = 2,
                    InsFirst = "Leo",
                    InsLast = "Lintag",
                    HiringDate = DateTime.Parse("2022-08-07"),
                    IsTenured = true,
                    InstructorRank = Rank.Professor,
                    PhoneNumber = "0922-241-2471"
                },
                new Instructor()
                {
                    InstructorId = 3,
                    InsFirst = "Eugenia",
                    InsLast = "Zhuo",
                    HiringDate = DateTime.Parse("2020-01-25"),
                    IsTenured = true,
                    InstructorRank = Rank.AssociateProfessor,
                    PhoneNumber = "0964-456-8721"
                }
                );
        }
    }
}
