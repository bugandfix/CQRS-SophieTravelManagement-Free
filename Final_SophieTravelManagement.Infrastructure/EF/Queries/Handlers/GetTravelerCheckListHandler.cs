
using Final_SophieTravelManagement.Application.DTO;
using Final_SophieTravelManagement.Domain.Repositories;
using Final_SophieTravelManagement.Infrastructure.EF.Contexts;
using Final_SophieTravelManagement.Infrastructure.EF.Models;
using Final_SophieTravelManagement.Infrastructure.EF.Queries;
using Final_SophieTravelManagement.Shared.Abstractions.Queries;
using Microsoft.EntityFrameworkCore;

namespace Final_SophieTravelManagement.Application.Queries.Handlers
{
    internal sealed class GetTravelerCheckListHandler : IQueryHandler<GetTravelerCheckList, TravelerCheckListDto>
    {
        private readonly DbSet<TravelerCheckListReadModel> _TravelerCheckLists;

        public GetTravelerCheckListHandler(ReadDbContext context)
            => _TravelerCheckLists = context.TravelerCheckList;

        public Task<TravelerCheckListDto> HandleAsync(GetTravelerCheckList query)
            => _TravelerCheckLists
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
