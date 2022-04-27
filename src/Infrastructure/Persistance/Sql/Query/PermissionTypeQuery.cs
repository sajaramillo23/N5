using N5.Domain.Entities;
using N5.Domain.Interfaces.Query;

namespace N5.Persistance.Sql.Query
{
    public  class PermissionTypeQuery : BaseQuery<PermissionType>, IPermissionTypeQuery
    {
        public PermissionTypeQuery(N5DbContext context) : base(context) { }
    }
}
