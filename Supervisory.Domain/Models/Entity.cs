using Supervisory.Domain.Interfaces;
using System;

namespace Supervisory.Domain.Models
{
    public class Entity : IEntity
    {
        public Guid Id { get; set; }
        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
