using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Oils.Data.Domains;
using Oils.Models.ViewModels;

namespace Oils
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Receiver, EditReceiverEntityViewModel>();
            CreateMap<Order, CreateOrderViewModel>();
            
        }
    }
}
