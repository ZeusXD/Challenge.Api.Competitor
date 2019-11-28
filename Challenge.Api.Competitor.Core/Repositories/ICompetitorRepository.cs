using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Challenge.Api.Competitor.Core.Models;

namespace Challenge.Api.Competitor.Core.Repositories
{
    public interface ICompetitorRepository : IRepository<Competer>
    {
        Task<IEnumerable<Competer>> GetAllWithBrandAsync();
        Task<Competer> GetWithBrandByIdAsync(int id);
        Task<IEnumerable<Competer>> GetAllWithBrandByBrandIdAsync(int brandId);
    }
}