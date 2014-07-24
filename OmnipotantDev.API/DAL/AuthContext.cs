using Microsoft.AspNet.Identity.EntityFramework;

namespace OmnipotantDev.API.DAL
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("AuthContext")
        {

        }
    }
}