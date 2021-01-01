﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        IdatabaseFactory Factory;
        public UnitOfWork(IdatabaseFactory Factory)
        {
            this.Factory = Factory;
        }
        public void Commit()
        {
            Factory.MyContext.SaveChanges();
        }
        public IRepositoryBase<T> getRepository<T>() where T : class
        {
            return new RepositoryBase<T>(Factory);
        }
        public void Dispose()
        {
            Factory.Dispose();
        }
    }
}
