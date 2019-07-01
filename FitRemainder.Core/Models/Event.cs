using System;
using System.Collections.Generic;
using System.Text;

namespace FitRemainder.Core.Models
{
    public class Event
    {
        public Guid Id { get; protected set; }
        public Category Category { get; protected set; }
        public DateTime AddedAt { get; protected set; }
        public DateTime RemainAt { get; protected set; }
    }
}
