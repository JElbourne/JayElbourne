using System;
using System.Linq;
using JayElbourne.Models.Project;
using JayElbourneData;
using JayElbourneData.Models;
using Microsoft.AspNetCore.Mvc;

namespace JayElbourne.Controllers
{
    public class ProjectController : Controller
    {
        private IProject m_projects;
        
        public ProjectController(IProject _projects)
        {
            m_projects = _projects;
        }

        public IActionResult Index()
        {
            var projectModels = m_projects.GetAll();

            var listingResult = projectModels
                .Select(result => new ProjectIndexListingModel
                {
                    Id = result.Id,
                    UrlSlug = result.UrlSlug,
                    Title = result.Title,
                    Description = result.Description,
                    ImageUrl = result.ImageUrl,
                    Status = result.ProjectStatus.Name,
                    PostedOn = result.PostedOn
                });

            var model = new ProjectIndexModel()
            {
                Projects = listingResult
        };

            return View(model);
        }

        public IActionResult Detail(string _slug)
        {
            var project = _db.Projects.FirstOrDefault(x => x.UrlSlug == _slug);

            return View(project);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
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
