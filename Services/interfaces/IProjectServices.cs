using Task_Management_System_API.Models;
using Task_Management_System_API.Models.DTO.ProjectDTOs;

namespace Task_Management_System_API.Services.interfaces
{
    public interface IProjectServices
    {
        public IEnumerable<ProjectDTO> GetAll();
        public ProjectDTO GetByID(int id);
        public Task<string> Add(ProjectDTO projectDTO);
        public Task<string> Update(int id, ProjectDTO projectDTO);
        public int Delete(int id);
        public Task<List<ApplicationUser>> GetAllUsers(int projectId);
        public void AssignToTask(int projectId ,Models.Task task);    

    }
}
