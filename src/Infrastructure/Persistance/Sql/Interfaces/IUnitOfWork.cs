using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace N5.Persistance.Sql.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        N5DbContext Context { get; }
        Task<int> Commit();
    }
}
