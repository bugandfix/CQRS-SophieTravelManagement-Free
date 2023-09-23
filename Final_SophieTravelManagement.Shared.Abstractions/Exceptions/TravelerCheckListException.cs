namespace Final_SophieTravelManagement.Shared.Abstractions.Exceptions
{
    public abstract class TravelerCheckListException : Exception
    {
        protected TravelerCheckListException(string message) : base(message)
        {

        }
    }
}
