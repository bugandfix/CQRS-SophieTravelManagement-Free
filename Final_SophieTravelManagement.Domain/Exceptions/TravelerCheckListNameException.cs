using Final_SophieTravelManagement.Shared.Abstractions.Exceptions;

namespace Final_SophieTravelManagement.Domain.Exceptions
{
    public class TravelerCheckListNameException : TravelerCheckListException
    {

        public TravelerCheckListNameException() : base("Traveler CheckList list name cannot be empty.")
        {
        }
    }
}
