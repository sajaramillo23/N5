using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;
using N5.Persistance.Sql.Interfaces;

namespace N5.Persistance.Sql.Command
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
