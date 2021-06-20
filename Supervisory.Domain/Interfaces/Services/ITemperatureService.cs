using Supervisory.Domain.ViewModels;
using System.Collections.Generic;

namespace Supervisory.Domain.Interfaces.Services
{
    public interface ITemperatureService
    {
        void Create(TemperatureViewModel model);
        List<TemperatureViewModel> ReadAll();
    }
}
