using Supervisory.Domain.Interfaces.Repositories;
using Supervisory.Domain.Models;
using Supervisory.Infra.Data;
using System.Collections.Generic;
using System.Linq;
using System;

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
            try
            {
                var list = _context.Temperatures.ToList().OrderBy(p => p.Date).ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw new Exception($"Erro ao tentar buscar a lista de temperaturas ! \n Erro: {ex.Message}");
            }
        }

  

    }
}
