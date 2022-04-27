using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;

namespace N5.Persistance.Sql.Command
{
    public class PermissionTypeRepository : BaseRepository<PermissionType>, IPermissionTypeRepository
    {
        public PermissionTypeRepository(N5DbContext context) : base(context)
        {
        }
    }
}
