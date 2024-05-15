using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Domain.Dto
{
    public class CustomerUpdateDto
    {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MobileNumber { get; set; }
        public string? EmailId { get; set; }
    }
}
