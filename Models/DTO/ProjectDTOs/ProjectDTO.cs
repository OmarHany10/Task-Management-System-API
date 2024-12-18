using System.ComponentModel.DataAnnotations;

namespace Task_Management_System_API.Models.DTO.ProjectDTOs
{
    public class ProjectDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime EndDate { get; set; }

        public string CreatedBy { get; set; }
    }

}
