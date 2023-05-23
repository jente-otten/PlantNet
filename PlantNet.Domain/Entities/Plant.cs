using PlantNet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Domain.Entities
{
    public class Plant : AuditableEntity
    {
        public int Id { get; set; }
        public Species Species { get; set; }
        public Location Location { get; set; }
        public DateOnly PurchaseDate { get; set; }


    }
}
