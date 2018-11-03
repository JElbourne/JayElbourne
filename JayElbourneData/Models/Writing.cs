using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Writing : Project
    {
        [Required]
        [DataType(DataType.Text)]
        public string Type { get; set; }

        [Required]
        [MinLength(1000, ErrorMessage = "Written Body must be at least 1000 characters long")]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

    }
}
