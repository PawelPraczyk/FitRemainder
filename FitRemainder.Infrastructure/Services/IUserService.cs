using FitRemainder.Infrastructure.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitRemainder.Infrastructure.Services
{
    public interface IUserService
    {
        void Register(string email, string username, string password);
        UserDto Get(string email);
    }
}
