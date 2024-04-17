using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentManagement.Application.IRepositories
{
    public interface IBaseRepository<T> where T:class
    {
        Task<IEnumerable<T>> GetAllData();

        Task<T> GetById(int id);

        int Delete(int id);

    }
}
