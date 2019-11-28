using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Challenge.Api.Competitor.Core.Models
{
    public class Brand
    {
        public Brand()
        {
            Competitors = new Collection<Competer>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Competer> Competitors { get; set; }
    }
}