using Final_SophieTravelManagement.Domain.Consts;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands
{
    public record CreateTravelerCheckListWithItems(Guid Id, string Name, ushort Days, Gender Gender,
       DestinationWriteModel Destionation) : ICommand;

    public record DestinationWriteModel(string City, string Country);
}

