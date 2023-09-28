using AlicanteITELEC1C.Models;
using AlicanteITELEC1C.Services;

namespace AlicanteITELEC1C.Services
{
    public class MyFakeDataService : IMyFakeDataService
    {
        public List<Student> StudentList { get; }

        public List<Instructor> InstructorList { get; }

        public MyFakeDataService() 
        {
            StudentList = new List<Student>
            {
                new Student()
                {
                    Id= 1,FirstName = "Gabriel",LastName = "Montano", Course = Course.BSIT, AdmissionDate = DateTime.Parse("2022-08-26"), GPA = 1.5, Email = "ghaby021@gmail.com"
                },
                new Student()
                {
                    Id= 2,FirstName = "Zyx",LastName = "Montano", Course = Course.BSIS, AdmissionDate = DateTime.Parse("2022-08-07"), GPA = 1, Email = "zyx@gmail.com"
                },
                new Student()
                {
                    Id= 3,FirstName = "Aerdriel",LastName = "Montano", Course = Course.BSCS, AdmissionDate = DateTime.Parse("2020-01-25"), GPA = 1.5, Email = "aerdriel@gmail.com"
                }
            };
            InstructorList = new List<Instructor>()
            {
                new Instructor()
                {
                    InstructorId = 1, InsFirst = "Gabriel", InsLast = "Montano", HiringDate = DateTime.Parse("2022-08-26"), IsTenured = false, InstructorRank = Rank.Instructor
                },
                new Instructor()
                {
                    InstructorId = 2, InsFirst = "Leo", InsLast = "Lintag", HiringDate = DateTime.Parse("2022-08-07"), IsTenured = true, InstructorRank = Rank.Professor
                },
                new Instructor()
                {
                    InstructorId = 3, InsFirst = "Eugenia", InsLast = "Zhuo", HiringDate = DateTime.Parse("2020-01-25"), IsTenured = true, InstructorRank = Rank.AssociateProfessor
                }

            };
        }
    }
}
