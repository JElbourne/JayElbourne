using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Architecture : Project
    {

        [Required]
        [DataType(DataType.Text)]
        public string Classification { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Area { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Floors { get; set; }
    }
}
