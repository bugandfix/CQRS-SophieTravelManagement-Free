using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Shared.Abstractions.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Queries
{
    public class GetTravelerCheckList : IQuery<TravelerCheckListDto>
    {
        public Guid Id { get; set; }
    }
}
