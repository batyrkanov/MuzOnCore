using AutoMapper;
using MuzOnCore.Data.Entities;
using MuzOnCore.Services.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MuzOnCore.Common.Mapping
{
    public class DataProfile : Profile
    {
        public DataProfile()
        {
            CreateMap<Artist, ArtistModel>(MemberList.None);
            CreateMap<Band, BandModel>(MemberList.None);
            CreateMap<Song, SongModel>(MemberList.None);
            CreateMap<Image, ImageModel>(MemberList.None);
        }
    }
}
