using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;

namespace N5.Persistance.Sql.Command
{
    public class ItermRepository : BaseRepository<Item>, IItemRepository
    {
        public ItermRepository(N5DbContext context) : base(context)
        {
        }
    }
}
