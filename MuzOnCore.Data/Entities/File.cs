using MuzOnCore.Data.Entities.Base;
using System;

namespace MuzOnCore.Data.Entities
{
    public class File : EntityBase<Guid>
    {
        public string Path { get; set; }
    }
}
