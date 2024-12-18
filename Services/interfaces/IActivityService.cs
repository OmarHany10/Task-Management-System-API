using Task_Management_System_API.Models.DTO.ActivityLogDTOs;
using Task_Management_System_API.Models.DTO.CommentDTOs;

namespace Task_Management_System_API.Services.interfaces
{
    public interface IActivityService
    {
        List<ActivityLogDTO> GetAllActivity();
        List<ActivityLogDTO> GetAllUserActivity(string userId);
        ActivityLogDTO GetActivityById(int id);
        Task<string> AddActivity(ActivityLogDTO activityDTO);
        Task<string> UpdateActivity(int id, ActivityLogDTO activityDTO);
        int DeleteActivity(int id);
    }
}
