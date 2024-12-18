using Task_Management_System_API.Models.DTO.CommentDTOs;

namespace Task_Management_System_API.Services.interfaces
{
    public interface ICommentService
    {
        List<CommentDTO> GetAllComments();
        List<CommentDTO> GetTaskComments(int taskId);
        List<CommentDTO> GetUserComments(string userID);
        CommentDTO GetCommentById(int id);
        Task<string> AddComment (CommentDTO commentDTO);
        Task<string> UpdateComment (int id, CommentDTO commentDTO);
        int DeleteComment (int id);

    }
}
