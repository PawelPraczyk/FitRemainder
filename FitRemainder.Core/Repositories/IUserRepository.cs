using FitRemainder.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FitRemainder.Core.Repositories
{
    public interface IUserRepository
    {
        User Get(Guid id);
        User Get(string email);
        void Add(User user);
        void Remove(Guid id);
        void Update(User user);
        IEnumerable<User> GetAll();
    }
}
