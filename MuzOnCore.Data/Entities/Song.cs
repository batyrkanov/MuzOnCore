using System.Collections.Generic;

namespace MuzOnCore.Data.Entities
{
    public class Song : File
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }
        public virtual ICollection<Band> Bands { get; set; }
        
        public Song()
        {
            Artists = new HashSet<Artist>();
            Bands = new HashSet<Band>();
        }
    }
}
