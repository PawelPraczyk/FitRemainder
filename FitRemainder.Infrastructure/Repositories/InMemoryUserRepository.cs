using FitRemainder.Core.Models;
using FitRemainder.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FitRemainder.Infrastructure.Repositories
{
    public class InMemoryUserRepository : IUserRepository
    {
        private static ISet<User> _users = new HashSet<User>
        {
            new User("user1@op.pl", "user1", "secret", "salt")
        };


        public void Add(User user)
        {
            _users.Add(user);
        }

        public User Get(Guid id)
            => _users.Single(x => x.Id == id);

        public User Get(string email)
        {
            var user = _users.Single(x => x.Email == email.ToLowerInvariant());
            return user;
        }

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public void Remove(Guid id)
        {
            var user = Get(id);
            _users.Remove(user);
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
