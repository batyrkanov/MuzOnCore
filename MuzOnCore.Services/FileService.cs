using AutoMapper;
using MuzOnCore.Data.Interfaces;
using MuzOnCore.Services.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace MuzOnCore.Services
{
    public class FileService : BaseService, IFileService
    {
        public FileService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        protected virtual string GetFileHash(byte[] file)
        {
            var shaHash = SHA512.Create().ComputeHash(file);
            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();
            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < shaHash.Length; i++)
            {
                sBuilder.Append(shaHash[i].ToString("x2"));
            }
            // Return the hexadecimal string
            return sBuilder.ToString();
        }
    }
}
