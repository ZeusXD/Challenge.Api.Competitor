using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Challenge.Api.Competitor.Core.Models;

namespace Challenge.Api.Competitor.Core.Repositories
{
    public interface IBrandRepository : IRepository<Brand>
    {
        Task<IEnumerable<Brand>> GetAllWithCompetitorAsync();
        Task<Brand> GetWithCompetitorByIdAsync(int id);
    }
}