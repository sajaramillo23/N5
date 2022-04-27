using N5.Domain.Entities;
using N5.Domain.Interfaces.Query;

namespace N5.Persistance.Sql.Query
{
    public class UserQuery : BaseQuery<User>, IUserQuery
    {
        public UserQuery(N5DbContext context) : base(context) { }
    }
}
