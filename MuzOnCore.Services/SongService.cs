using AutoMapper;
using Microsoft.AspNetCore.Http;
using MuzOnCore.Data.Entities;
using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services.Enums;
using MuzOnCore.Services.Extensions;
using MuzOnCore.Services.Interfaces;
using MuzOnCore.Services.Models;
using MuzOnCore.Services.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuzOnCore.Services
{
    public class SongService : BaseQueryService<Song, SongModel, SongSortType>, ISongService
    {
        public SongService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public Task AddSongAsync(SongModel songModel, IFormFile file)
        {
            throw new NotImplementedException();
        }

        public Task DeleteSongAsync(Guid songId)
        {
            throw new NotImplementedException();
        }

        public Task<SongModel> GetSongByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SongModel> GetSongs()
        {
            throw new NotImplementedException();
        }

        public Task<SongModel> SaveSongAsync(string fileName, byte[] file)
        {
            throw new NotImplementedException();
        }

        public Task UpdateSongAsync(SongModel songModel, IFormFile image)
        {
            throw new NotImplementedException();
        }

        protected override IQueryable<Song> Order(IQueryable<Song> items, bool isFirst, QueryOrder<SongSortType> order)
        {
            switch (order.OrderType)
            {
                case SongSortType.Name:
                    return items.OrderWithDirectionBy(isFirst, order.Direction, x => x.Name);
            }

            throw new ArgumentOutOfRangeException(nameof(order.OrderType));
        }

        protected override IQueryable<Song> Search(IQueryable<Song> items, QuerySearch search)
        {
            if (!string.IsNullOrEmpty(search?.Value))
                return items.Where(x => x.Name.ToLower().Contains(search.Value.ToLower())).OrderBy(song => song.Name);
            return items;
        }
    }
}
