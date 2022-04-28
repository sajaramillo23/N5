using N5.Persistance.Sql.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace N5.Persistance.Sql
{
    public class UnitOfWork : IUnitOfWork
    {
        public N5DbContext Context { get; }

        public UnitOfWork(N5DbContext context)
        {
            Context = context;
        }

        public async Task<int> Commit()
        {
            return await Context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}
