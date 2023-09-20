using Microsoft.AspNetCore.Mvc;
using AlicanteITELEC1C.Models;

namespace AlicanteITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        List<Instructor> InstructorList = new List<Instructor>()
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

        public IActionResult Index()
        {

            return View(InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)
                return View(instructor);

            return NotFound();
        }

        [HttpGet]
        public IActionResult AddInstructor()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddInstructor(Instructor newInstructor)
        {
            InstructorList.Add(newInstructor);
            return View("Index", InstructorList);
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)//was a instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = InstructorList.FirstOrDefault(ins => ins.InstructorId == instructorChanges.InstructorId);

            if (instructor != null)
            {
                instructor.InsFirst = instructorChanges.InsFirst; 
                instructor.InsLast = instructorChanges.InsLast;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.IsTenured = instructorChanges.IsTenured;
            }

            return View("Index", InstructorList);
        }
    }
}
