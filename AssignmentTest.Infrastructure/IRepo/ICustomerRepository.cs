using AssignmentTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Infrastructure.IRepo
{
    public interface ICustomerRepository
    {
        Task<Customer?> Create(Customer customer);
        Task<Customer?> Update(Customer customer);
        Task<List<Customer>> Get(Customer customer);
        Task<bool> Delete(int customerId);
    }
}
