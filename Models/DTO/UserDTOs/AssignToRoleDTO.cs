using System.ComponentModel.DataAnnotations;

namespace Task_Management_System_API.Models.DTO.UserDTOs
{
    public class AssignToRoleDTO
    {
        [Required]
        public string RoleName { get; set; }

        [Required]
        public string UserID { get; set; }
    }
}
