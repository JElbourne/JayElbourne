using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JayElbourne.Models.Project
{
    public class ProjectIndexListingModel
    {
        public long Id { get; set; }
        public string UrlSlug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public DateTime PostedOn { get; set; }
    }
}
