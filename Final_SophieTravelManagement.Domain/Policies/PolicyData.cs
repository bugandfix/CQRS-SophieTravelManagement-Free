using Final_SophieTravelManagement.Domain.ValueObjects;

namespace Final_SophieTravelManagement.Domain.Policies
{
    public record PolicyData(TravelDays Days, Consts.Gender Gender, ValueObjects.Temperature Temperature,
        Destination Destination);
}
