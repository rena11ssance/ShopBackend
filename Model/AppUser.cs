using Microsoft.AspNetCore.Identity;

namespace ShopBackend.Model
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
    }
}
