using EmploymentManagement.Application.IRepositories.IAuthRepositories;
using EmploymentManagement.Model.Authentication;
using Microsoft.AspNetCore.Identity;

namespace EmploymentManagement.Repository.Repositories.AuthRepositories
{
    public class AuthRepository : IAuthRepository
    {
        private readonly UserManager<IdentityUser> _usermanager;
        private readonly RoleManager<IdentityRole> _rolemanager;
        public AuthRepository(UserManager<IdentityUser> usermanager, RoleManager<IdentityRole> rolemanager)
        {
            _usermanager = usermanager;
            _rolemanager = rolemanager;
        }
        public async Task<int> Register(Register regster)
        {
            var user = await _usermanager.FindByEmailAsync(regster.Email);
            if (user != null)
            {
                return 0;
            }
            IdentityUser newuser = new IdentityUser()
            {
                Email = regster.Email,
                UserName = regster.UserName,
            };
            IdentityResult result = await _usermanager.CreateAsync(newuser, regster.Password);
            if (!result.Succeeded)
            {
                return -1;
            }
            return 1;
        }
    }
}
