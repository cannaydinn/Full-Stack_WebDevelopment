using IdentityDataProtectionProject.Dtos;
using IdentityDataProtectionProject.Types;

namespace IdentityDataProtectionProject.Services
{
    public interface IUserService
    {
        Task<ServiceMessage> AddUser(AddUserDto user);
    }
}
