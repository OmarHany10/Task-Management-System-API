namespace Task_Management_System_API.Repository.interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        T Add(T entity);
        void Delete(int id);
        T Update(T entity);
    }
}
