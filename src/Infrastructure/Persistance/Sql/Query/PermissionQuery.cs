using N5.Domain.Entities;
using N5.Domain.Interfaces.Query;

namespace N5.Persistance.Sql.Query
{
    public class PermissionQuery : BaseQuery<Permission>, IPermissionQuery
    {
        public PermissionQuery(N5DbContext context) : base(context) { }
    }
}
