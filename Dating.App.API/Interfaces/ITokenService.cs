using Dating.App.API.Entities;

namespace Dating.App.API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
