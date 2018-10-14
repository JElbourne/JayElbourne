using System;
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

        [Route("{slug}")]
        public IActionResult Detail()
        {
            return View();
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
