using System;
using System.Collections.Generic;

namespace Challenge.Api.Competitor.Core.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Competer = new HashSet<Competer>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Competer> Competer { get; set; }
    }
}
