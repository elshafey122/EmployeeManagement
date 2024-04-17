using AutoMapper;
using EmploymentManagement.Application;
using EmploymentManagement.Application.IRepositories;
using EmploymentManagement.Application.IRepositories.IAuthRepositories;
using EmploymentManagement.Repository.Repositories;
using Microsoft.AspNetCore.Identity;

namespace EmploymentManagement.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly ApplicationDbContext _context;
        protected readonly IMapper _mapper;
        public IDeptRepository Departements { get; private set; }
        public IEmployeeRepository Employees { get; private set; }
        public ITaskRepository Tasks { get; private set; }
        public IAuthRepository Auths { get; private set; }

        public UnitOfWork(ApplicationDbContext context,
            UserManager<IdentityUser> usermanager, RoleManager<IdentityRole> rolemanager)
        {
            _context = context;
            Departements = new DeptRepository(_context, _mapper);
            Employees = new EmployeeRepository(_context, _mapper);
            Tasks = new TaskRepository(_context, _mapper);
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}
