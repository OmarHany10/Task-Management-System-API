using Task_Management_System_API.Data;
using Task_Management_System_API.Repository.Implementations;
using Task_Management_System_API.Repository.interfaces;
using Task_Management_System_API.Services;
using Task_Management_System_API.Services.interfaces;

namespace Task_Management_System_API.UOK
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext context;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            Users = new UserService(context);
            Projects = new ProjectRepository(context);
            Tasks = new TaskRepository(context);
            Comments = new CommentRepository(context);
            ActivityLogs = new ActivityLogRepository(context);
        }
        public IUserService Users { get; private set; }

        public IProjectRepository Projects { get; private set; }

        public ITaskRepository Tasks { get; private set; }
        public ICommentRepository Comments { get; private set; }
        public IActivityLogRepository ActivityLogs { get; private set; }


        public void Dispose()
        {
            context.Dispose();
        }

        public int save()
        {
            return context.SaveChanges();
        }
    }
}
