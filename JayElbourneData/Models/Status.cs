using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Status
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(20, MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 20 characters long")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(200, MinimumLength = 10,
            ErrorMessage = "Name must be between 10 and 200 characters long")]
        public string Description { get; set; }
    }
}
