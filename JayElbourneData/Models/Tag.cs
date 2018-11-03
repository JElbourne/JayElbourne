using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace JayElbourneData.Models
{
    public class Tag
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 20 characters long")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(140, MinimumLength = 10,
            ErrorMessage = "Name must be between 10 and 140 characters long")]
        public string Description { get; set; }

        private string _slug;

        public string UrlSlug
        {
            get
            {
                if (_slug == null && Name != null)
                {
                    _slug = Regex.Replace(Name.ToLower(), "[^a-z0-9]", "-");
                }
                return _slug;
            }
            set { _slug = value; }
        }
    }
}
