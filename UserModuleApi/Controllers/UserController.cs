using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using UserModuleApi.Infrastracture;
using UserModuleApi.Mappings;
using UserModuleApi.Models;
using UserModuleApi.ViewModels;

namespace UserModuleApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserModuleDBContext _context;
        private readonly UserProfile _userProfile;

        public UserController(UserModuleDBContext context,
            UserProfile userProfile)
        {
            _context = context ?? throw new System.ArgumentNullException(nameof(context));
            _userProfile = userProfile ?? throw new ArgumentNullException(nameof(userProfile));
        }

        [HttpGet]
        public UserViewModel GetUsers()
        {
            var user = new User()
            {
                Id = 1,
                Name = "ss",
                Adress = "Yerevan",
                BirthDate = 1998,
                Created = DateTime.Now,
                Info = "Text",
                IsActive = true,
                UserName = "Vzgo@gmail.com"
            };
            var ee = _userProfile.GetMapper().Map<UserViewModel>(user);
            return _userProfile.GetMapper().Map<UserViewModel>(user);
        }
    }
}