using AutoMapper;
using MuzOnCore.Data.Entities;
using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services.Interfaces;
using MuzOnCore.Services.Models;
using System;
using System.Threading.Tasks;

namespace MuzOnCore.Services
{
    public class ImageService : FileService, IImageService
    {
        public ImageService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public async Task<ImageModel> GetAsync(Guid id)
        {
            var img = await _uow.GetRepository<Image>().GetByIdAsync(id);
            return _mapper.Map<ImageModel>(img);
        }

        public async Task<ImageModel> SaveImageAsync(string fileName, byte[] file)
        {
            #region Need refactor
            System.Drawing.Image image = System.Drawing.Image.FromStream(new System.IO.MemoryStream(file));
            var imageModel = new ImageModel
            {
                Height = image.Height,
                Width = image.Width
            };
            await _uow.GetRepository<Image>().InsertAsync(_mapper.Map<Image>(imageModel));
            await _uow.SaveChangesAsync();
            return imageModel;
            #endregion
        }
    }
}
