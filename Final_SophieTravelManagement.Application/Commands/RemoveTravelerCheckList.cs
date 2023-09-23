using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands
{
    public record RemoveTravelerCheckList(Guid Id) : ICommand;
}

