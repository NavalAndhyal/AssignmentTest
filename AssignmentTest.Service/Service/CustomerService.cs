using AssignmentTest.Application.IService;
using AssignmentTest.Domain.Dto;
using AssignmentTest.Domain.Models;
using AssignmentTest.Infrastructure.IRepo;
using AssignmentTest.Infrastructure.Repo;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Application.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ICustomerRepository customerRepository,IMapper mapper) 
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }
        public Task<Customer?> Create(Customer customer)
        {
            return _customerRepository.Create(customer);
        }

        public Task<bool> Delete(int customerId)
        {
            return _customerRepository.Delete(customerId);
        }

        public Task<List<Customer>> Get(CustomerFilterDto customerFilterDto)
        {
            var customer = _mapper.Map<Customer>(customerFilterDto);
            return _customerRepository.Get(customer);
        }

        public Task<Customer?> Update(CustomerUpdateDto customerUpdateDto)
        {
            var customer = _mapper.Map<Customer>(customerUpdateDto);
            return _customerRepository.Update(customer);
        }
    }
}
