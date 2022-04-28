using Microsoft.EntityFrameworkCore;
using N5.Domain.Interfaces.Command;
using N5.Persistance.Sql.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace N5.Persistance.Sql.Command
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IUnitOfWork context)
        {
            _unitOfWork = context;
        }
        public async Task<T> Add(T entity)
        {
            var result = await _unitOfWork.Context.Set<T>().AddAsync(entity);
            await Complete();

            return result.Entity;
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
           await  _unitOfWork.Context.Set<T>().AddRangeAsync(entities);
            await Complete();
        }

        public async Task Remove(T entity)
        {
            _unitOfWork.Context.Set<T>().Remove(entity);
            await Complete();
        }

        public async Task RemoveRange(IEnumerable<T> entities)
        {
            _unitOfWork.Context.Set<T>().RemoveRange(entities);
            await Complete();
        }

        public async Task Update(T entity) 
        {
            _unitOfWork.Context.ChangeTracker.Clear();
            _unitOfWork.Context.Set<T>().Update(entity);
            
            await Complete();
        }

        public async Task<int> Complete()
        {
            return await _unitOfWork.Commit();
        }
    }
}
