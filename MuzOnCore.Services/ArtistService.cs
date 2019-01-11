using AutoMapper;
using Microsoft.AspNetCore.Http;
using MuzOnCore.Data.Entities;
using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services.Enums;
using MuzOnCore.Services.Interfaces;
using MuzOnCore.Services.Models;
using MuzOnCore.Services.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuzOnCore.Services
{
    public class ArtistService : BaseQueryService<Artist, ArtistModel, ArtistSortType>, IArtistService
    {
        public ArtistService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public Task AddArtistAsync(ArtistModel artistModel, IFormFile image)
        {
            throw new NotImplementedException();
        }

        public Task DeleteArtistAsync(Guid artistId)
        {
            throw new NotImplementedException();
        }

        public Task<ArtistModel> GetArtistByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArtistModel> GetArtists()
        {
            throw new NotImplementedException();
        }
        
        public Task UpdateArtistAsync(ArtistModel artistModel, IFormFile image)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<Artist> Order(IQueryable<Artist> items, bool isFirst, QueryOrder<ArtistSortType> order)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<Artist> Search(IQueryable<Artist> items, QuerySearch search)
        {
            throw new NotImplementedException();
        }
    }
}
