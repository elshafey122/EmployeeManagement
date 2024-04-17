using EmploymentManagement.Application.Dto;
using EmploymentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentManagement.Application.IRepositories
{
    public interface IEmployeeRepository:IBaseRepository<Employee>
    {
        Task<Employee> AddEmployee(EmployeeDto emp);
        Task<Employee> UpdateEmployee(int id,EmployeeDto emp);
    }
}
