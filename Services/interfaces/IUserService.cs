using Task_Management_System_API.Models;
using Task_Management_System_API.Models.DTO.UserDTOs;

namespace Task_Management_System_API.Services.interfaces
{
    public interface IUserService
    {
        IEnumerable<ApplicationUser> GetAll();
        Task<ApplicationUser> GetByID(string id);
        Task<ApplicationUser> Update(string id, UpdateUserDTO user);
        Task<int> Delete(string id);
    }
}
