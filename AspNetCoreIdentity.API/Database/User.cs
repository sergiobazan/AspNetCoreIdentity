using Microsoft.AspNetCore.Identity;

namespace AspNetCoreIdentity.API.Database;

public class User : IdentityUser
{
    public string? Initials { get; set; }

}
