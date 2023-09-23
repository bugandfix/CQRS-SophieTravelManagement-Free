using Final_SophieTravelManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Domain.Policies
{
    public interface ITravelerItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<TravelerItem> GenerateItems(PolicyData data);

    }
}
