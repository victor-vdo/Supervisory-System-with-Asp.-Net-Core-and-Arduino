using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Supervisory.Domain.Models
{
    [Table("temperature")]
    public class Temperature : Entity
    {
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
