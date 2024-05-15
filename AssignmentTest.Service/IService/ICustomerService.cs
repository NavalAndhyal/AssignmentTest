using AssignmentTest.Domain.Dto;
using AssignmentTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Application.IService
{
    public interface ICustomerService
    {
        Task<Customer?> Create(Customer customer);
        Task<Customer?> Update(CustomerUpdateDto customerUpdateDto);
        Task<List<Customer>> Get(CustomerFilterDto customerFilterDto);
        Task<bool> Delete(int customerId);
    }
}
