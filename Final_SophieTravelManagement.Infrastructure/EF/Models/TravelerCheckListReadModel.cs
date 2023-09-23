using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Models
{
    internal class TravelerCheckListReadModel
    {
        public Guid Id { get; set; }
        public int Version { get; set; }
        public string Name { get; set; }
        public DestinationReadModel Destination { get; set; }
        public ICollection<TravelerItemReadModel> Items { get; set; }
    }
}
