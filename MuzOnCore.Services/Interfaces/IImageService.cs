using MuzOnCore.Services.Models;
using System;
using System.Threading.Tasks;

namespace MuzOnCore.Services.Interfaces
{
    public interface IImageService : IFileService
    {
        Task<ImageModel> GetAsync(Guid id);
        Task<ImageModel> SaveImageAsync(string fileName, byte[] file);
    }
}
