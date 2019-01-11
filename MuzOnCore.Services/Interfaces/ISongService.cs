using Microsoft.AspNetCore.Http;
using MuzOnCore.Data.Entities;
using MuzOnCore.Services.Enums;
using MuzOnCore.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuzOnCore.Services.Interfaces
{
    public interface ISongService : IBaseQueryService<Song, SongModel, SongSortType>
    {
        IEnumerable<SongModel> GetSongs();
        Task<SongModel> GetSongByIdAsync(Guid id);
        Task AddSongAsync(SongModel songModel, IFormFile file);
        Task UpdateSongAsync(SongModel songModel, IFormFile image);
        Task DeleteSongAsync(Guid songId);
    }
}
