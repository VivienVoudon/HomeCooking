﻿using System;
using System.Data;
using Repository.Pattern.Repositories;

namespace Repository.Pattern.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        void Dispose(bool disposing);
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        //void BeginTransaction(IsolationLevel isolationLevel = IsolationLevel.Unspecified);
        //bool Commit();
        //void Rollback();
    }
}