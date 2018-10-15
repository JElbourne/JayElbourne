using System;
using System.Linq;
using JayElbourne.DataContext;
using JayElbourne.Models;
using Microsoft.AspNetCore.Mvc;

namespace JayElbourne.Controllers
{
    [Route("project")]
    public class ProjectController : Controller
    {
        private readonly ProjectDataContext _db;

        public ProjectController(ProjectDataContext db)
        {
            _db = db;
        }

        [Route("")]
        public IActionResult Index()
        {
            var projects = _db.Projects.OrderByDescending(x => x.Posted).Take(5).ToArray();

            return View(projects);
        }

        [Route("{slug}")]
        public IActionResult Detail(string slug)
        {
            var project = _db.Projects.FirstOrDefault(x => x.Slug == slug);

            return View(project);
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Project project)
        {
            if (!ModelState.IsValid)
                return View();

            project.Posted = DateTime.Now;

            _db.Projects.Add(project);
            _db.SaveChanges();

            return View();
        }
    }
}
