using MuzOnCore.Services.Models.Base;
using System;
using System.Collections.Generic;

namespace MuzOnCore.Services.Models
{
    public class ArtistModel : BaseModel
    {
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public Guid? ImageId { get; set; }
        public ImageModel Image { get; set; }
        public IList<SongModel> Songs { get; set; }
        public IList<BandModel> Bands { get; set; }
    }
}
