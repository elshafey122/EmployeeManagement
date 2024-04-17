using EmploymentManagement.Application.IRepositories;

namespace EmploymentManagement.Application
{
    public interface IUnitOfWork : IDisposable
    {
        IDeptRepository Departements { get; }
        IEmployeeRepository Employees { get; }
        ITaskRepository Tasks { get; }
        int Complete();
    }
}
