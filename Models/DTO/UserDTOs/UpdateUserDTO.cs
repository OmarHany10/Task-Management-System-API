using System.ComponentModel.DataAnnotations;

namespace Task_Management_System_API.Models.DTO.UserDTOs
{
    public class UpdateUserDTO
    {
        [Required]
        public string Usermame { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}
