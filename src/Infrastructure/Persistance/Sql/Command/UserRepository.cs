using N5.Domain.Entities;
using N5.Domain.Interfaces.Command;

namespace N5.Persistance.Sql.Command
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(N5DbContext context) : base(context)
        {
        }
    }
}
