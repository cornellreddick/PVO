using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using PVO.Dtos;
using PVO.Models;

namespace PVO.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}