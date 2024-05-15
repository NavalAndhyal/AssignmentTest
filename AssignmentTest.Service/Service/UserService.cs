using AssignmentTest.Application.IRepo.UserRepo;
using AssignmentTest.Application.IService;
using AssignmentTest.Domain.Models;
using AssignmentTest.Infrastructure.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Application.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public Task<User> GetUserDtoForLogin(Login login)
        {
            return _userRepository.GetUserForLogin(login);
        }
    }
}
