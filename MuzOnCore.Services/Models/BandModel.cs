using MuzOnCore.Services.Models.Base;
using System;
using System.Collections.Generic;

namespace MuzOnCore.Services.Models
{
    public class BandModel : BaseModel
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? ImageId { get; set; }
        public ImageModel Image { get; set; }
        public IList<SongModel> Songs { get; set; }
        public IList<ArtistModel> Artists { get; set; }

    }
}
