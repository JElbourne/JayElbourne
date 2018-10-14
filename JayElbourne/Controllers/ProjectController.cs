using System;
using JayElbourne.Models;
using Microsoft.AspNetCore.Mvc;

namespace JayElbourne.Controllers
{
    [Route("project")]
    public class ProjectController : Controller
    {
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

            return View();
        }
    }
}
