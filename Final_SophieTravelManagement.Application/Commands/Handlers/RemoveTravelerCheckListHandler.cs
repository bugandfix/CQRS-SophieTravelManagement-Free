using Final_SophieTravelManagement.Application.Exceptions;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Shared.Abstractions.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Commands.Handlers
{
    internal sealed class RemoveTravelerCheckListHandler : ICommandHandler<RemoveTravelerCheckList>
    {
        private readonly ITravelerCheckListRepository _repository;

        public RemoveTravelerCheckListHandler(ITravelerCheckListRepository repository)
            => _repository = repository;

        public async Task HandleAsync(RemoveTravelerCheckList command)
        {
            var TravelerCheckList = await _repository.GetAsync(command.Id);

            if (TravelerCheckList is null)
            {
                throw new TravelerCheckListNotFound(command.Id);
            }

            await _repository.DeleteAsync(TravelerCheckList);
        }
    }
}
