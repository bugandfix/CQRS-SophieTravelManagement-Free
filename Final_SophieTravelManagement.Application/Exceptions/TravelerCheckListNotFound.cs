using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Exceptions
{
    public class TravelerCheckListNotFound : TravelerCheckListException
    {
        public Guid Id { get; }

        public TravelerCheckListNotFound(Guid id) : base($"Traveler CheckList list with ID '{id}' was not found.")
            => Id = id;
    }
}
