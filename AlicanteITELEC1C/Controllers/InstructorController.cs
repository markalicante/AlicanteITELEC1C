using Microsoft.AspNetCore.Mvc;
using AlicanteITELEC1C.Models;
using AlicanteITELEC1C.Services;

namespace AlicanteITELEC1C.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IMyFakeDataService _dummyData;

        public InstructorController(IMyFakeDataService dummyData)
        {
            _dummyData = dummyData;
        }

        public IActionResult Index()
        {

            return View(_dummyData.InstructorList);
        }

        public IActionResult ShowDetail(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

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
            _dummyData.InstructorList.Add(newInstructor);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)//was a instructor found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateInstructor(Instructor instructorChanges)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == instructorChanges.InstructorId);

            if (instructor != null)
            {
                instructor.InsFirst = instructorChanges.InsFirst; 
                instructor.InsLast = instructorChanges.InsLast;
                instructor.InstructorRank = instructorChanges.InstructorRank;
                instructor.HiringDate = instructorChanges.HiringDate;
                instructor.IsTenured = instructorChanges.IsTenured;
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
       public IActionResult DeleteInstructor(int id)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == id);

            if (instructor != null)//was a student found?
                return View(instructor);

            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteInstructor(Student newInstructor)
        {
            Instructor? instructor = _dummyData.InstructorList.FirstOrDefault(ins => ins.InstructorId == newInstructor.Id);

            if (instructor != null)//was a student found?
                _dummyData.InstructorList.Remove(instructor);

            return RedirectToAction("Index");
        }
    }
}
