using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitRemainder.Infrastructure.Dtos;
using FitRemainder.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FitRemainder.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{email}")]
        public UserDto Get(string email)
        {
            var user = _userService.Get(email);

            return user;
        }

       
    }
}
