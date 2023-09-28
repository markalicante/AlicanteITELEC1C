using AlicanteITELEC1C.Models;


namespace AlicanteITELEC1C.Services
{
    public interface IMyFakeDataService
    {
        public List<Student> StudentList { get; }

        public List<Instructor> InstructorList { get; }
    }
}
