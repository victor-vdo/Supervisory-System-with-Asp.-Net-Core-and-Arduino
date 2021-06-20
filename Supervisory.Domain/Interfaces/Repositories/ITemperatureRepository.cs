using Supervisory.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Supervisory.Domain.Interfaces.Repositories
{
    public interface ITemperatureRepository
    {
        void Create(Temperature temperature);
        List<Temperature> ReadAll();
    }
}
