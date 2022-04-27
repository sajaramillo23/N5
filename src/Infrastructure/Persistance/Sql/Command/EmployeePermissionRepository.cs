using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;

namespace N5.Persistance.Sql.Command
{
    public class EmployeePermissionRepository : BaseRepository<EmployeePermission>, IEmployeePermissionRepository
    {
        public EmployeePermissionRepository(N5DbContext context) : base(context)
        {
        }
    }
}
