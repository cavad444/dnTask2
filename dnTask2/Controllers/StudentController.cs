using dnTask2.Models;
using dnTask2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace dnTask2.Controllers
{
    public class StudentController : Controller
    {
        
        public ViewResult Index()
        {
            List<Student> Students = new List<Student>()
            {
                new Student{Id = 1, FullName = "Cavad Manafov", Point = 71},
                new Student{Id = 2, FullName = "Muharrem Ince", Point = 63},
                new Student{Id = 3, FullName = "Kemal Kilicdaroglu", Point = 69},
                new Student{Id = 4, FullName = "Sinan Ogan", Point = 61}
            };

            List<Group> Groups = new List<Group>()
            {
                new Group{Id = 1, Name = "695.21"},
                new Group{Id = 2, Name = "693.21"},
                new Group{Id = 3, Name = "691.21"},
                new Group{Id = 4, Name = "697.21"}
            };

            StudentViewModel studentVm = new StudentViewModel
            {
                Students = Students,
                Groups = Groups,
            };

            return View(studentVm);
        }

        public ViewResult Detail(int id)
        {
            List<Student> Students = new List<Student>()
            {
                new Student{Id = 1, FullName = "Cavad Manafov", Point = 71},
                new Student{Id = 2, FullName = "Muharrem Ince", Point = 63},
                new Student{Id = 3, FullName = "Kemal Kilicdaroglu", Point = 69},
                new Student{Id = 4, FullName = "Sinan Ogan", Point = 61}
            };


            Student studentFiltered = Students.Find(x => x.Id == id);
            return View(studentFiltered);
        }
    }
}
