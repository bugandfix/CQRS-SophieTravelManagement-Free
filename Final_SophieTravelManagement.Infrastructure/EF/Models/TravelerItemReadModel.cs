using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Models
{
    internal class TravelerItemReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public uint Quantity { get; set; }
        public bool IsTaken { get; set; }

        public TravelerCheckListReadModel TravelerCheckList { get; set; }
    }
}
