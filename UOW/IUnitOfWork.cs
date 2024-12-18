using Task_Management_System_API.Repository.interfaces;
using Task_Management_System_API.Services.interfaces;

namespace Task_Management_System_API.UOK
{
    public interface IUnitOfWork: IDisposable
    {
        IUserService Users { get; }
        IProjectRepository Projects { get; }
        ITaskRepository Tasks { get; }
        ICommentRepository Comments { get; }
        IActivityLogRepository ActivityLogs { get; }

        int save();
    }
}
