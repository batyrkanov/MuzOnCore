﻿using MuzOnCore.Data.Interfaces;

namespace MuzOnCore.Data.Entities.Base
{
    public class EntityBase : IEntityBase
    { }

    public class EntityBase<T> : IEntityBase<T>
    {
        public T Id { get; set; }
    }
}
