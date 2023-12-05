using Microsoft.AspNetCore.Identity;

namespace FisioFinancials.Domain.Model.Entities;

public sealed class User : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ICollection<Received> Receiveds { get; set; }

    public User() : base() { }

    public string FullName()
    {
        return $"{FirstName} + {LastName}";
    }
}
