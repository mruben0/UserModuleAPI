using AutoMapper;
using System;
using System.Collections.Generic;
using UserModuleApi.Models;
using UserModuleApi.ViewModels;

namespace UserModuleApi.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
        }

        public IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserViewModel>().ForMember(s=>s.BirthDate,m=>m.MapFrom(e=>e.BirthDate.ToString()));
                cfg.CreateMap<UserViewModel, User>().ForMember(s => s.BirthDate, m => m.MapFrom(e => Convert.ToInt32(e.BirthDate)));
            });
            return config.CreateMapper();
        }
    }
}