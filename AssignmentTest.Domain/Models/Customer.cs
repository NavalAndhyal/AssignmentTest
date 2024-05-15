using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Domain.Models
{
    [Table("TblCustomer")]
    public class Customer
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }

        [Required]
        public string? MobileNumber { get; set; }
        [EmailAddress]
        public string? EmailId { get; set; }
    }
}
