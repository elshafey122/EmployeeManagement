using EmploymentManagement.Model.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmploymentManagement.Application.IRepositories.IAuthRepositories
{
    public interface IAuthRepository
    {
         Task <int> Register(Register regster);
    }
}
