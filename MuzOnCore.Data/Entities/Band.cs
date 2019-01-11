using MuzOnCore.Data.Entities.Base;
using System;
using System.Collections.Generic;

namespace MuzOnCore.Data.Entities
{
    public class Band : EntityBase<Guid>
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ImageId { get; set; }
        public virtual Image Image { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<Artist> Artists { get; set; }

        public Band()
        {
            Songs = new HashSet<Song>();
            Artists = new HashSet<Artist>();
        }
    }
}
