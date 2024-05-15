using AssignmentTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Application.IRepo.UserRepo
{
    public interface IUserRepository
    {
        public Task<User?> GetUserForLogin(Login login);
    }
}
