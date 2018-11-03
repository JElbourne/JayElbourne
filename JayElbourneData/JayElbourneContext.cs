using System;
using JayElbourneData.Models;
using Microsoft.EntityFrameworkCore;

namespace JayElbourneData
{
    public class JayElbourneContext : DbContext
    {
        public JayElbourneContext(DbContextOptions options) : base(options) {  }

        public DbSet<Animation> Animations { get; set; }
        public DbSet<Architecture> Architectures { get; set; }
        public DbSet<Programming> Programs { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Gaming> Games { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Reference> References { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Writing> Writings { get; set; }
    }
}
