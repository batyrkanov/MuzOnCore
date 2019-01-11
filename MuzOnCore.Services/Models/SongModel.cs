using System.Collections.Generic;

namespace MuzOnCore.Services.Models
{
    public class SongModel : FileModel
    {
        public string Name { get; set; }
        public string FileName { get; set; }
        public IList<ArtistModel> Artists { get; set; }
        public IList<BandModel> Bands { get; set; }
    }
}
