using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;
using N5.Persistance.Sql.Interfaces;

namespace N5.Persistance.Sql.Command
{
    public class EmployeePermissionRepository : BaseRepository<EmployeePermission>, IEmployeePermissionRepository
    {
        public EmployeePermissionRepository(IUnitOfWork context) : base(context)
        {
        }
    }
}
