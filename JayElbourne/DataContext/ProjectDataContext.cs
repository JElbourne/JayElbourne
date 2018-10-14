using System;
using JayElbourne.Models;
using Microsoft.EntityFrameworkCore;

namespace JayElbourne.DataContext
{
    public class ProjectDataContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public ProjectDataContext(DbContextOptions<ProjectDataContext> options)
            :base(options)
        {
            Database.EnsureCreated();
        }
    }
}
