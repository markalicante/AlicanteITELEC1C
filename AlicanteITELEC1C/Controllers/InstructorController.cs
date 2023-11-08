using Microsoft.AspNetCore.Mvc;
using AlicanteITELEC1C.Models;
using AlicanteITELEC1C.Data;

namespace AlicanteITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly AppDbContext _dbData;

        public InstructorController(AppDbContext dbData)
        {
            _dbData = dbData;
        }

        public IActionResult Index()
        {

            return View(_dbData.Instructors);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == id);

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

            if (!ModelState.IsValid)
                return View();

            _dbData.Instructors.Add(newInstructor);
            _dbData.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)//was a instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == instructorChanges.InstructorId);

            if (instructor != null)
            {
                instructor.InsFirst = instructorChanges.InsFirst; 
                instructor.InsLast = instructorChanges.InsLast;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.IsTenured = instructorChanges.IsTenured;
            }
            _dbData.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
       public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)//was a student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Student newInstructor)
        {
            Instructor? instructor = _dbData.Instructors.FirstOrDefault(ins => ins.InstructorId == newInstructor.Id);

            if (instructor != null)//was a student found?
                _dbData.Instructors.Remove(instructor);
                _dbData.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
