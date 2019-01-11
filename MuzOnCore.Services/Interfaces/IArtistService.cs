using Microsoft.AspNetCore.Http;
using MuzOnCore.Data.Entities;
using MuzOnCore.Services.Enums;
using MuzOnCore.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuzOnCore.Services.Interfaces
{
    public interface IArtistService : IBaseQueryService<Artist, ArtistModel, ArtistSortType>
    {
        IEnumerable<ArtistModel> GetArtists();
        Task<ArtistModel> GetArtistByIdAsync(Guid id);
        Task AddArtistAsync(ArtistModel artistModel, IFormFile image);
        Task UpdateArtistAsync(ArtistModel artistModel, IFormFile image);
        Task DeleteArtistAsync(Guid artistId);
    }
}
