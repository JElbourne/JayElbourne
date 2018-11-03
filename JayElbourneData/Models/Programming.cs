using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Programming : Project
    {
        [Required]
        [DataType(DataType.Text)]
        public string RepositoryUrl { get; set; }

        public Video DemoVideo { get; set; }
    }
}
