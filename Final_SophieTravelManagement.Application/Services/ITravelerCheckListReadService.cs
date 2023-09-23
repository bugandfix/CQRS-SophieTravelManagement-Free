using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Application.Services
{
    public interface ITravelerCheckListReadService
    {
        Task<bool> ExistsByNameAsync(string name);
    }
}
