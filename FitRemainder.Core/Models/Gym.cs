using System;
using System.Collections.Generic;
using System.Text;

namespace FitRemainder.Core.Models
{
    public class Gym
    {
        public Guid Id { get; protected set; }
        public string Name { get; protected set; }
        public string Country { get; protected set; }
        public string City { get; protected set; }
        public string Address { get; protected set; }
    }
}
