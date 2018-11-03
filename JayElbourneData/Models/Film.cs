using System.Collections.Generic;

namespace JayElbourneData.Models
{
    public class Film : Project
    {
        public IEnumerable<Video> Videos { get; set; }
    }
}
