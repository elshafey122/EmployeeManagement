using AutoMapper;
using EmploymentManagement.Application.Dto;
using EmploymentManagement.Application.IRepositories;
using EmploymentManagement.Model;


namespace EmploymentManagement.Repository.Repositories
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        protected readonly ApplicationDbContext _context;
        public readonly IMapper _mapper;
        public EmployeeRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Employee> AddEmployee(EmployeeDto emp)
        {
            var Employee = _mapper.Map<Employee>(emp);
            await _context.Employees.AddAsync(Employee);
            return Employee;
        }

        public async Task<Employee> UpdateEmployee(int id, EmployeeDto emp)
        {
            var employee =await _context.Employees.FindAsync(id);
            employee.Age = emp.Age;
            employee.Salary = emp.Salary;
            employee.DeptId = emp.DeptId;
            employee.Email = emp.Email;
            employee.ManagerId = emp.ManagerId;
            employee.Name = emp.Name;
            employee.Phone = emp.Phone;
            return employee;
        }
    }
}