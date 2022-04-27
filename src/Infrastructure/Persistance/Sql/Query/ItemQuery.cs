using N5.Domain.Entities;
using N5.Domain.Interfaces.Query;

namespace N5.Persistance.Sql.Query
{
    public class ItemQuery : BaseQuery<Item>, IItemQuery
    {
        public ItemQuery(N5DbContext context) : base(context) { }
    }
}
