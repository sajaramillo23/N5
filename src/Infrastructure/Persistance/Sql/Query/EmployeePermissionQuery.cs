using N5.Domain.Entities;
using N5.Domain.Interfaces.Query;

namespace N5.Persistance.Sql.Query
{
    public class EmployeePermissionQuery : BaseQuery<EmployeePermission>, IEmployeePermissionQuery
    {
        public EmployeePermissionQuery(N5DbContext context) : base(context) { }
    }
}
