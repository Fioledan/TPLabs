using System.Web.Mvc;
using TPlab2.Models;

namespace TPlab2.Controllers
{
    public class StudentController : Controller
    {
        private static StudentModel[] students = new StudentModel[]
        {
            new StudentModel
            {
                Id = 1,
                FullName = "Иванов Иван Иванович",
                Group = "ИС-21",
                Age = 19,
                Phone = "+7 (999) 123-45-67",
                AverageScore = 4.5
            },
            new StudentModel
            {
                Id = 2,
                FullName = "Петров Петр Петрович",
                Group = "ИС-22",
                Age = 20,
                Phone = "+7 (999) 222-33-44",
                AverageScore = 4.2
            },
            new StudentModel
            {
                Id = 3,
                FullName = "Сидоров Сергей Олегович",
                Group = "ИС-23",
                Age = 18,
                Phone = "+7 (999) 555-66-77",
                AverageScore = 4.8
            }
        };

        private static int currentIndex = 0;

        [HttpGet]
        public ActionResult Index()
        {
            return View(students[currentIndex]);
        }

        [HttpGet]
        public ActionResult Create()
        {
            StudentModel model = new StudentModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(StudentModel model)
        {
            students[0] = model;
            currentIndex = 0;
            return View("Index", model);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            return View(students[currentIndex]);
        }

        [HttpPost]
        public ActionResult Edit(StudentModel model)
        {
            students[currentIndex] = model;
            return View("Index", model);
        }

        [HttpGet]
        public ActionResult ShowAll()
        {
            ViewData["UseInnerHelper"] = true;
            ViewData["TableTitle"] = "Список студентов";

            return View(students);
        }
    }
}