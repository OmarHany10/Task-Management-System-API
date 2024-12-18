using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_Management_System_API.Models.DTO.ActivityLogDTOs
{
    public class ActivityLogDTO
    {
        public string Action { get; set; }

        public DateTime TimeStamp { get; set; }

        public string EntityType { get; set; }

        public int EntityID { get; set; }
        public string UserID { get; set; }
    }
}
