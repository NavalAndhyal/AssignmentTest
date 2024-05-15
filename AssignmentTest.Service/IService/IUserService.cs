using AssignmentTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Application.IService
{
    public interface IUserService
    {
        public Task<User> GetUserDtoForLogin(Login login);

    }
}
