using System;
using System.Threading.Tasks;
using Challenge.Api.Competitor.Core.Repositories;

namespace Challenge.Api.Competitor.Core
{
    public interface IUnitOfWork : IDisposable
    {
        ICompetitorRepository CompetitorRepository { get; }
        IBrandRepository BrandRepository { get; }
        Task<int> CommitAsync();
    }
}
