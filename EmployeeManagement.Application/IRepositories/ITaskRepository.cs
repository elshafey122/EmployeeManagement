using EmploymentManagement.Application.Dto;
using EmploymentManagement.Model;

namespace EmploymentManagement.Application.IRepositories
{
    public interface ITaskRepository:IBaseRepository<Taski>
    {
        Task<Taski> AddTask(TaskDto task);
        Task<Taski>UpdateTask(int id,TaskDto task);
        Task<IEnumerable<Employee>> GetManagerEmployees(int Managerid);
        Task<IEnumerable<Taski>> GetManagerTasks(int Managerid);
    }
}
