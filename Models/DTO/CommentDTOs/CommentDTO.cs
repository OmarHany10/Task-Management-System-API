using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task_Management_System_API.Models.DTO.CommentDTOs
{
    public class CommentDTO
    {
        public string Text { get; set; }
        public string UserID { get; set; }
        public int TaskID { get; set; }
    }
}
