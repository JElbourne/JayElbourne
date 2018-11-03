using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Reference
    {
        public long Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Url { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Description { get; set; }
    }
}
