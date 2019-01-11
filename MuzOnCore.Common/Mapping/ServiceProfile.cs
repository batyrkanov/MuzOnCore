using AutoMapper;
using MuzOnCore.Data.Entities;
using MuzOnCore.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuzOnCore.Common.Mapping
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<ArtistModel, Artist>(MemberList.None);
            CreateMap<BandModel, Band>(MemberList.None);
            CreateMap<SongModel, Song>(MemberList.None);
            CreateMap<ImageModel, Image>(MemberList.None);
        }
    }
}
