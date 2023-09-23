using Final_SophieTravelManagement.Application.DTO.External;
using Final_SophieTravelManagement.Application.Services;
using Final_SophieTravelManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.Services
{
    internal sealed class DumbWeatherService : IWeatherService
    {
        public Task<WeatherDto> GetWeatherAsync(Destination destination)
            => Task.FromResult(new WeatherDto(new Random().Next(5, 30)));
    }
}
