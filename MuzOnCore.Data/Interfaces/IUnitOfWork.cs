﻿using System;
using System.Threading.Tasks;

namespace MuzOnCore.Data.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<T> GetRepository<T>() where T : class, IEntityBase, new();
        void SaveChanges();
        Task SaveChangesAsync();
        void RunInTransaction(Action action);
        Task RunInTransactionAsync(Func<Task> actionAsync);
    }
}
