using Supervisory.Domain.Interfaces.Repositories;
using Supervisory.Domain.Models;
using Supervisory.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervisory.Infra.Repositories
{
    public class TemperatureRepository : ITemperatureRepository
    {
        public SupervisoryContext _context;

        public TemperatureRepository(SupervisoryContext context)
        {
            _context = context;
        }

        public void Create(Temperature temperature)
        {
            _context.Temperatures.Add(temperature);
            _context.SaveChanges();
        }

        public List<Temperature> ReadAll()
        {
            return  _context.Temperatures.ToList().OrderBy(p => p.Date).ToList();
        }

  

    }
}
