using System.Collections.Generic;

namespace JayElbourneData.Models
{
    public class Animation : Project
    {
        public IEnumerable<Video> Videos { get; set; }
    }
}
