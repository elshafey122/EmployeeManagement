using EmploymentManagement.Application.Dto;
using EmploymentManagement.Model;

namespace EmploymentManagement.Application.IRepositories
{
    public interface IDeptRepository :IBaseRepository<Departement>
    {
        Task<Departement> AddDept(DeptDto dept);
        Task<Departement> UpdateDept(int id,DeptDto dept);
    }
}
