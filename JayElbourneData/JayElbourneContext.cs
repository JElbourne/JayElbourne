using System;
using JayElbourneData.Models;
using Microsoft.EntityFrameworkCore;

namespace JayElbourneData
{
    public class JayElbourneContext : DbContext
    {
        public JayElbourneContext(DbContextOptions options) : base(options) {  }

        public DbSet<Project> Projects { get; set; }
    }
}
