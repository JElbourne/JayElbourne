using JayElbourneData;
using JayElbourneData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace JayElbourneServices
{
    public class ProjectService : IProject
    {
        private JayElbourneContext m_context;

        public ProjectService(JayElbourneContext _context)
        {
            m_context = _context;
        }

        public void Add(Project newProject)
        {
            m_context.Add(newProject);
            m_context.SaveChanges();
        }

        public IEnumerable<Project> GetAll()
        {
            return m_context.Projects
                .Include(project => project.ProjectStatus)
                .Include(project => project.Tags)
                .Include(project => project.Images)
                .Include(project => project.Credits)
                .Include(project => project.References);
        }

        public Project GetById(int id)
        {
            return GetAll().FirstOrDefault(project => project.Id == id);
        }
    }
}
