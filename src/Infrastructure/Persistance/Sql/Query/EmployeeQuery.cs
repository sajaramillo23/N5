using N5.Domain.Entities;
using N5.Domain.Interfaces.Query;


namespace N5.Persistance.Sql.Query
{
    public class EmployeeQuery : BaseQuery<Employee>, IEmployeeQuery
    {
        public EmployeeQuery(N5DbContext context) : base(context) { }
    }
}
