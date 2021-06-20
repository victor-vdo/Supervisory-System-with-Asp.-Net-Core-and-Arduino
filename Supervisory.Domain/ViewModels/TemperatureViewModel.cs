using System;

namespace Supervisory.Domain.ViewModels
{
    public class TemperatureViewModel 
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
