using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<User, UserViewModel>(); cfg.CreateMap<UserViewModel, User>(); }) ;
            return config.CreateMapper();
        }
    }
}
