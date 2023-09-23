using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Models
{
    internal class DestinationReadModel
    {
        public string City { get; set; }
        public string Country { get; set; }

        public static DestinationReadModel Create(string value)
        {
            var splitLocalization = value.Split(',');
            return new DestinationReadModel
            {
                City = splitLocalization.First(),
                Country = splitLocalization.Last()
            };
        }

        public override string ToString()
            => $"{City},{Country}";
    }
}
