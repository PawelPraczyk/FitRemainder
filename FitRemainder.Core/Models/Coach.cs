using System;
using System.Collections.Generic;
using System.Text;

namespace FitRemainder.Core.Models
{
    public class Coach
    {
        public Guid Id { get; protected set; }
        public Guid UserId { get; protected set; }
        public Gym Gym { get; protected set; }
    }
}
