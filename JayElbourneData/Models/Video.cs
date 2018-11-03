using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Video
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string VideoUrl { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, MinimumLength = 10,
            ErrorMessage = "Name must be between 10 and 200 characters long")]
        public string Description { get; set; }
    }
}
