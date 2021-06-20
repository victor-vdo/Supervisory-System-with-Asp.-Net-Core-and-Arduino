using Supervisory.Domain.Interfaces;
using Supervisory.Domain.Interfaces.Repositories;
using Supervisory.Domain.Interfaces.Services;
using Supervisory.Domain.Models;
using Supervisory.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supervisory.Domain.Services
{
    public class TemperatureService : ITemperatureService
    {
        private readonly ITemperatureRepository _repository;

        public TemperatureService(ITemperatureRepository repository)
        {
            _repository = repository;
        }

        public void Create(TemperatureViewModel model)
        {
            var temperature = new Temperature
            {
                Date = model.Date,
                Value = model.Value
            };
             _repository.Create(temperature);
        }

        public List<TemperatureViewModel> ReadAll()
        {
            var models = new List<TemperatureViewModel>();
            var temperatures = _repository.ReadAll();

            foreach (var temperature in temperatures)
            {
                var model = new TemperatureViewModel 
                {
                    Date = temperature.Date, 
                    Id = temperature.Id, 
                    Value = temperature.Value
                };
                models.Add(model);
            }
            return models;
        }
    }
}
