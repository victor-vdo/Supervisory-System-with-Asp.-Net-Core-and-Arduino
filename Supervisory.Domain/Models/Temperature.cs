using System;
using System.Collections.Generic;
using System.Text;

namespace Supervisory.Domain.Models
{
    public class Temperature : Entity
    {
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
