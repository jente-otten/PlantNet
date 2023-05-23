using PlantNet.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Domain.Entities
{
    public class Location : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public LightLevel LightLevel { get; set; }
        public IList<Plant>? Plants { get; set; }
        

    }
}
