using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;

namespace N5.Persistance.Sql.Command
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(N5DbContext context) : base(context)
        {
        }
    }
}
