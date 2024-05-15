using AssignmentTest.Application.IRepo.UserRepo;
using AssignmentTest.Domain.Models;
using AssignmentTest.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Infrastructure.Repo.UserRepo
{
    public class UserRepository : IUserRepository
    {
        private readonly CustomerContext _context;
        public UserRepository(CustomerContext customerContext) 
        {
            _context = customerContext;
        }

        public async Task<User?> GetUserForLogin(Login login)
        {
            var User = await _context.Users.FirstOrDefaultAsync(u => u.Username == login.UserName && login.Password == login.Password);
            if(User != null)
                return User;
            return null;
        }

    }
}
