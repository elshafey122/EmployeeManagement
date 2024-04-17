using AutoMapper;
using EmploymentManagement.Application.Dto;
using EmploymentManagement.Application.IRepositories;
using EmploymentManagement.Model;

namespace EmploymentManagement.Repository.Repositories
{
    public class DeptRepository : BaseRepository<Departement>, IDeptRepository
    {
        private readonly ApplicationDbContext _context;
        public readonly IMapper _mapper;
        public DeptRepository(ApplicationDbContext context, IMapper mapper) : base(context)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<Departement> AddDept(DeptDto dept)
        {
            var NewDept = _mapper.Map<Departement>(dept);
            await _context.Departements.AddAsync(NewDept);
            return NewDept;
        }
        public async Task<Departement> UpdateDept(int id, DeptDto dept)
        {
            var dep = await _context.Departements.FindAsync(id);
            dep.Name = dept.Name;
            return dep;
        }
    }
}
