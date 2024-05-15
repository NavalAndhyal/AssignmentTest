using AssignmentTest.Domain.Dto;
using AssignmentTest.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTest.Application.Mapper
{
    public class CustomerMapperProfile : Profile
    {
        public CustomerMapperProfile() 
        {
            CreateMap<CustomerUpdateDto, Customer>().ReverseMap();
            CreateMap<CustomerFilterDto, Customer>().ReverseMap();
        }
    }
}
