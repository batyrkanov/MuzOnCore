using Microsoft.AspNetCore.Http;
using MuzOnCore.Data.Entities;
using MuzOnCore.Services.Enums;
using MuzOnCore.Services.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MuzOnCore.Services.Interfaces
{
    public interface IBandService : IBaseQueryService<Band, BandModel, BandSortType>
    {
        IEnumerable<BandModel> GetBands();
        Task<BandModel> GetBandByIdAsync(Guid id);
        Task AddBandAsync(BandModel bandModel, IFormFile image);
        Task UpdateBandAsync(BandModel bandModel, IFormFile image);
        Task DeleteBandAsync(Guid bandId);
    }
}
