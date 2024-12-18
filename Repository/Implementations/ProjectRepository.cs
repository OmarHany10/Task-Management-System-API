using Task_Management_System_API.Data;
using Task_Management_System_API.Models;
using Task_Management_System_API.Repository.interfaces;

namespace Task_Management_System_API.Repository.Implementations
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext context;

        public ProjectRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public Project Add(Project entity)
        {
            context.Projects.Add(entity);
            return entity;
        }

        public void Delete(int id)
        {
            var project = GetByID(id);
            context.Projects.Remove(project);
        }

        public IEnumerable<Project> GetAll()
        {
            return context.Projects.ToList();
        }

        public Project GetByID(int id)
        {
            return context.Projects.FirstOrDefault(p => p.Id == id);
        }

        public Project Update(Project entity)
        {
            context.Update(entity);
            return entity;
        }
    }
}
