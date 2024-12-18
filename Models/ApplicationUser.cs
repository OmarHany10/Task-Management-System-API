using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task_Management_System_API.Models
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        public ICollection<Project>? Projects { get; set; }
        public ICollection<Task>? Tasks { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<ActivityLog>? ActivityLogs { get; set; }


    }
}
