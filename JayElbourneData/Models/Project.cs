using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JayElbourneData.Models
{
    public class Project
    {
        public Project()
        {
            Featured = false;
            Published = false;
        }

        public long Id { get; set; }

        private string _slug;

        public string UrlSlug
        {
            get
            {
                if (_slug == null && Title != null)
                {
                    _slug = Regex.Replace(Title.ToLower(), "[^a-z0-9]", "-");
                }
                return _slug;
            }
            set { _slug = value; }
        }

        [Display(Name = "Project Title")]
        [Required]
        [DataType(DataType.Text)]
        [StringLength(250, MinimumLength = 5,
            ErrorMessage = "Title must be between 5 and 250 characters long")]
        public string Title { get; set; }

        [Required]
        [MinLength(100, ErrorMessage = "Project Description must be at least 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public bool Featured { get; set; }

        public bool Published { get; set; }

        public DateTime PostedOn { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public Status ProjectStatus { get; set; }

        public virtual IEnumerable<Tag> Tags { get; set; }

        public virtual IEnumerable<Image> Images { get; set; }

        public virtual IEnumerable<Credit> Credits { get; set; }

        public virtual IEnumerable<Reference> References { get; set; }
    }
}
