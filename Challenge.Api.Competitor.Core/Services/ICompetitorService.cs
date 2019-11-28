using System.Collections.Generic;
using System.Threading.Tasks;
using Challenge.Api.Competitor.Core.Models;

namespace Challenge.Api.Competitor.Core.Service 
{
    public interface ICompetitorService
    {
        Task<IEnumerable<Competer>> GetAllWithBrand();
        Task<Competer> GetCompetitorById(int id);
        Task<Competer> CreateCompetitor(Competer newCompetitor);
        Task UpdateCompetitor(Competer competitorToBeUpdated, Competer competitor);
        Task DeleteCompetitor(Competer competitor);
    }
}