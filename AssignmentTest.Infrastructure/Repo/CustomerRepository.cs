using AssignmentTest.Domain.Models;
using AssignmentTest.Infrastructure.Context;
using AssignmentTest.Infrastructure.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Infrastructure.Repo
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CustomerContext _context;
        public CustomerRepository(CustomerContext customerContext) 
        {
            _context = customerContext;
        }
        public async Task<Customer?> Create(Customer customer)
        {
            await _context.Customers.AddAsync(customer);
            var insertedRows = await _context.SaveChangesAsync();
            return insertedRows > 0 ? customer : null;
        }

        public async Task<bool> Delete(int id)
        {
            var existingCustomer = _context.Customers.AsNoTracking().FirstOrDefault(c => c.Id == id);
            if (existingCustomer != null)
            {
                _context.Customers.Remove(existingCustomer);
                var deletedRows = await _context.SaveChangesAsync();
                return deletedRows > 0;
            }
            return false;
        }

        public async Task<List<Customer>> Get(Customer customer)
        {
            var query = _context.Customers.AsQueryable();

            if(customer.Id != 0)
            {
                query = query.Where(c => c.Id == customer.Id);
            }

            if (!string.IsNullOrEmpty(customer.FirstName))
            {
                query = query.Where(c => c.FirstName!.Equals(customer.FirstName));
            }

            if (!string.IsNullOrEmpty(customer.EmailId))
            {
                query = query.Where(c => c.EmailId!.Equals(customer.EmailId));
            }

            if (!string.IsNullOrEmpty(customer.MobileNumber))
            {
                query = query.Where(c => c.MobileNumber!.Equals(customer.MobileNumber));
            }

            return await query.ToListAsync();
        }

        public async Task<Customer?> Update(Customer customer)
        {
            var existingCustomer = _context.Customers.AsNoTracking().FirstOrDefault(c => c.Id == customer.Id);
            if (existingCustomer != null)
            {
                _context.Customers.Update(customer);
                var updatedRows = await _context.SaveChangesAsync();
                return updatedRows > 0 ? customer : null;
            }
            return null;
        }
    }
}
