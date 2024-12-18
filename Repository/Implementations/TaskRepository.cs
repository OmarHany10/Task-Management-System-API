using Microsoft.EntityFrameworkCore;
using Task_Management_System_API.Data;
using Task_Management_System_API.Repository.interfaces;

namespace Task_Management_System_API.Repository.Implementations
{
    public class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext context;

        public TaskRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Models.Task Add(Models.Task entity)
        {
            context.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            var task = GetByID(id);
            context.Tasks.Remove(task);
        }

        public IEnumerable<Models.Task> GetAll()
        {
            return context.Tasks.ToList();
        }

        public List<Models.Task> GetAllFinished()
        {
            return context.Tasks.Where(t => t.CompleteDate != null).ToList();
        }

        public List<Models.Task> GetAllOverdue()
        {
            return context.Tasks.Where(t => t.DueDate < DateTime.Now && t.CompleteDate == null).ToList();
        }

        public List<Models.Task> GetAllUpcoming()
        {
            return context.Tasks.Where(t => t.DueDate > DateTime.Now && t.CompleteDate == null).ToList();
        }

        public List<Models.Task> GetAllUserFinished(string userId)
        {
            return context.Tasks.Where(t => t.CompleteDate != null && t.UserID == userId).ToList();
        }

        public List<Models.Task> GetAllUserOverdue(string userId)
        {
            return context.Tasks.Where(t => t.DueDate < DateTime.Now && t.CompleteDate == null && t.UserID == userId).ToList();
        }

        public List<Models.Task> GetAllUserUpcoming(string userId)
        {
            return context.Tasks.Where(t => t.CompleteDate == null &&  t.DueDate > DateTime.Now && t.UserID == userId).ToList();
        }

        public Models.Task GetByID(int id)
        {
            return context.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public List<Models.Task> GetTasksByProjectId(int id)
        {
            var task = context.Tasks.Where(t => t.ProjectID == id).ToList();
            return task;
        }

        public List<Models.Task> GetTasksByUserId(string id)
        {
            var task = context.Tasks.Where(t => t.UserID == id).ToList();
            return task;
        }

        public Models.Task Update(Models.Task entity)
        {
            context.Update(entity);
            return entity;
        }
    }
}
