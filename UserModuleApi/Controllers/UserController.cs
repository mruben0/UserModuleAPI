using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public List<UserViewModel> GetUsers()
        {
            var users = _context.Users.ToList();
            return _userProfile.GetMapper().Map<List<UserViewModel>>(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var user = _context.Users.SingleOrDefault(e => e.Id == id);
            if (user == null)
            {
                return NotFound($"User With Id {id} does not exist");
            }
            var userModel = _userProfile.GetMapper().Map<UserViewModel>(user);

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser([FromBody] UserViewModel userViewModel)
        {
            var actionDate = DateTime.Now;
            var user = _userProfile.GetMapper().Map<User>(userViewModel);
            user.Created = actionDate;
            _context.Users.Add(user);
            _context.SaveChanges();
            return Ok(userViewModel);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUser([FromRoute]int id, [FromBody]UserViewModel userViewModel)
        {
            var user = _context.Users.SingleOrDefault(e => e.Id == id);
            if (user == null)
            {
                return NotFound($"User With Id {id} does not exist");
            }

            user.Name = userViewModel.Name;
            user.Address = userViewModel.Address;
            user.BirthDate = Convert.ToInt32(userViewModel.BirthDate);
            user.Info = userViewModel.Info;
            user.IsActive = userViewModel.IsActive;
            user.UserName = userViewModel.UserName;

            _context.Update(user);
            _context.SaveChanges();
            return Ok(userViewModel);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoveUser([FromRoute]int id)
        {
            var user = _context.Users.SingleOrDefault(e => e.Id == id);
            if (user == null)
            {
                return NotFound($"User With Id {id} does not exist");
            }
            _context.Remove(user);
            _context.SaveChanges();
            return Ok();
        }
    }
}