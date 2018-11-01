using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JayElbourneData.Models
{
    public class Project
    {
        public Project()
        {
            Featured = false;
        }

        public long Id { get; set; }

        private string _slug;

        public string Slug
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
            ErrorMessage = "Title must be between 5 and 100 characters long")]
        public string Title { get; set; }

        [Required]
        [MinLength(100, ErrorMessage = "Blog posts must be at least 100 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        public bool Featured { get; set; }

        public DateTime Posted { get; set; }

        public Status ProjectStatus { get; set; }

        public enum Status
        {
            [Display(Name = "Work In Progress")]
            WorkInProgress,
            Complete
        }


    }
}
