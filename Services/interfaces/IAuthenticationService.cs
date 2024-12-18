using Task_Management_System_API.Models.DTO.UserDTOs;

namespace Task_Management_System_API.Services.interfaces
{
    public interface IAuthService
    {
        public Task<UserDTO> Register(RegisterDTO registerDTO);
        public Task<UserDTO> Login(LoginDTO loginDTO);
        public Task<AssignRoleDTO> AssignToRole(AssignToRoleDTO assignToRoleDTO);
    }
}
