using System;
using System.Collections.Generic;

namespace Challenge.Api.Competitor.Repository
{
    public partial class Competer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal? Amount { get; set; }
        public bool? Marker { get; set; }
        public int? IdBrand { get; set; }

        public virtual Brand IdBrandNavigation { get; set; }
    }
}
