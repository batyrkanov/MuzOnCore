using AutoMapper;
using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services.Interfaces;
using System;

namespace MuzOnCore.Services
{
    public class BaseService : IBaseService
    {
        protected readonly IMapper _mapper;
        protected readonly IUnitOfWork _uow;

        protected Guid Id => Guid.NewGuid();

        public BaseService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
    }
}
