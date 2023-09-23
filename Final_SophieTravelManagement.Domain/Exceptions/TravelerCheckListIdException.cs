using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class TravelerCheckListIdException : TravelerCheckListException
    {

        public TravelerCheckListIdException() : base("Traveler Checklist ID cannot be empty.")
        {
        }
    }
}
