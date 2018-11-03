using System;
using System.Linq;
using JayElbourneData;
using JayElbourneData.Models;
using Microsoft.AspNetCore.Mvc;

namespace JayElbourne.Controllers
{
    [Route("project")]
    public class ProjectController : Controller
    {
        private readonly JayElbourneContext _db;

        public ProjectController(JayElbourneContext db)
        {
            _db = db;
        }

        [Route("")]
        public IActionResult Index()
        {
            var projects = _db.Projects.OrderByDescending(x => x.PostedOn).Take(5).ToArray();

            return View(projects);
        }

        [Route("{slug}")]
        public IActionResult Detail(string _slug)
        {
            var project = _db.Projects.FirstOrDefault(x => x.UrlSlug == _slug);

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

            project.PostedOn = DateTime.Now;

            _db.Projects.Add(project);
            _db.SaveChanges();

            return View();
        }
    }
}
