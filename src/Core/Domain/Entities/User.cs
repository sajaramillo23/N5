using Microsoft.AspNetCore.Identity;

namespace N5.Domain.Entities
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentificationDocument { get; set; }
    }
}
