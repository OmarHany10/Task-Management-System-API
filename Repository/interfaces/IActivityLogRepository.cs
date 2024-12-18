using Task_Management_System_API.Models;

namespace Task_Management_System_API.Repository.interfaces
{
    public interface IActivityLogRepository: IBaseRepository<ActivityLog>
    {
        List<ActivityLog> GetAllUserActivityLog(string Id);
    }
}
