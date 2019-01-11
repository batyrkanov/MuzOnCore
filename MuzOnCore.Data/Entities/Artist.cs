using MuzOnCore.Data.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MuzOnCore.Data.Entities
{
    public class Artist : EntityBase<Guid>
    {
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public Guid? ImageId { get; set; }
        public virtual Image Image { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public virtual ICollection<Band> Bands { get; set; }

        public Artist()
        {
            Songs = new HashSet<Song>();
            Bands = new HashSet<Band>();
        }
    }
}
