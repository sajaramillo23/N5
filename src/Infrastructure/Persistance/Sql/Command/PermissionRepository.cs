using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;

namespace N5.Persistance.Sql.Command
{
    public class PermissionRepositoryy : BaseRepository<Permission>, IPermissionRepository
    {
        public PermissionRepositoryy(N5DbContext context) : base(context)
        {
        }
    }
}
