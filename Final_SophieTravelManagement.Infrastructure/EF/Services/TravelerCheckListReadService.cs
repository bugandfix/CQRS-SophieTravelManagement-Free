using Final_SophieTravelManagement.Application.Services;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SophieTravelManagement.Infrastructure.EF.Services
{
    internal sealed class TravelerCheckListReadService : ITravelerCheckListReadService
    {
        private readonly DbSet<TravelerCheckListReadModel> _travelerCheckList;

        public TravelerCheckListReadService(ReadDbContext context)
            => _travelerCheckList = context.TravelerCheckList;

        public Task<bool> ExistsByNameAsync(string name)
            => _travelerCheckList.AnyAsync(pl => pl.Name == name);
    }
}
