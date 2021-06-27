using GithubGroup.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubGroup.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StudentsController(ApplicationDbContext DataBase)
        {
            _db = DataBase;
        }
        public IActionResult Index()
        {
            var students = _db.students.ToList();
            ViewData["students"] = students;
            return View();
        }
    }
}
