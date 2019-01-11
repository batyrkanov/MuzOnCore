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
    public class BandService : BaseQueryService<Band, BandModel, BandSortType>, IBandService
    {
        public BandService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public Task AddBandAsync(BandModel bandModel, IFormFile image)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBandAsync(Guid bandId)
        {
            throw new NotImplementedException();
        }
        
        public Task<BandModel> GetBandByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BandModel> GetBands()
        {
            throw new NotImplementedException();
        }

        public Task UpdateBandAsync(BandModel bandModel, IFormFile image)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<Band> Order(IQueryable<Band> items, bool isFirst, QueryOrder<BandSortType> order)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<Band> Search(IQueryable<Band> items, QuerySearch search)
        {
            throw new NotImplementedException();
        }
    }
}
