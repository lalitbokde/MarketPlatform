using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace MarketPlatform.Data
{
   public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        int SaveChanges();

    }
}
