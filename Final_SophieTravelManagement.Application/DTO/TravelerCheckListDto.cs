using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.DTO
{
    public class TravelerCheckListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DestinationDto Destination { get; set; }
        public IEnumerable<TravelerItemDto> Items { get; set; }
    }
}
