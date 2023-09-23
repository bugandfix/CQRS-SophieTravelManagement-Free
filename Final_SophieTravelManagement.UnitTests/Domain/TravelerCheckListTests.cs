using Final_SophieTravelManagement.Domain.ValueObjects;
using Final_SophieTravelManagement.Domain.Entities;
using Final_SophieTravelManagement.Domain.Events;
using Final_SophieTravelManagement.Domain.Exceptions;
using Final_SophieTravelManagement.Domain.Factories;
using Final_SophieTravelManagement.Domain.Policies;
using Shouldly;
using Xunit;

namespace Final_SophieTravelManagement.UnitTests.Domain
{
    public class TravelerCheckListTests
    {
        [Fact]
        public void AddItem_Throws_TravelerItemAlreadyExistsException_When_There_Is_Already_Item_With_The_Same_Name()
        {
            //ARRANGE
            var TravelerCheckList = GetTravelerCheckList();
            TravelerCheckList.AddItem(new TravelerItem("Item 1", 1));

            //ACT
            var exception = Record.Exception(() => TravelerCheckList.AddItem(new TravelerItem("Item 1", 1)));

            //ASSERT
            exception.ShouldNotBeNull();
            exception.ShouldBeOfType<TravelerItemAlreadyExistsException>();
        }

        [Fact]
        public void AddItem_Adds_TravelerItemAdded_Domain_Event_On_Success()
        {
            var travelerCheckList = GetTravelerCheckList();

            var exception = Record.Exception(() => travelerCheckList.AddItem(new TravelerItem("Item 1", 1)));

            exception.ShouldBeNull();
            travelerCheckList.Events.Count().ShouldBe(1);

            var @event = travelerCheckList.Events.FirstOrDefault() as TravelerItemAdded;

            @event.ShouldNotBeNull();
            @event.TravelerItem.Name.ShouldBe("Item 1");
        }


        #region ARRANGE

        private TravelerCheckList GetTravelerCheckList()
        {
            var travelerCheckList = _factory.Create(Guid.NewGuid(), "MyList", Destination.Create("Shiraz, Iran"));
            travelerCheckList.ClearEvents();
            return travelerCheckList;
        }

        private readonly ITravelerCheckListFactory _factory;

        public TravelerCheckListTests()
        {
            _factory = new TravelerCheckListFactory(Enumerable.Empty<ITravelerItemsPolicy>());
        }

        #endregion

    }
}