using System.ComponentModel.DataAnnotations;

namespace JayElbourneData.Models
{
    public class Gaming : Project
    {
        [Required]
        [DataType(DataType.Text)]
        public string RepositoryUrl { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string PlayableUrl { get; set; }

        public Video Trailer { get; set; }
    }
}
