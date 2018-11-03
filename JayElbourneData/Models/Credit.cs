using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Credit
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Name must be between 5 and 50 characters long")]
        public string JobTitle { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 5,
            ErrorMessage = "Name must be between 5 and 50 characters long")]
        public string FullName { get; set; }
    }
}
