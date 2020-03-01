using AutoMapper;
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
                cfg.CreateMap<User, UserViewModel>();
                cfg.CreateMap<UserViewModel, User>();
            });
            return config.CreateMapper();
        }
    }
}