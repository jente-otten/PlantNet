﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantNet.Domain.Common
{
    public class AuditableEntity
    {
        public DateTime Created { get; set; }
        public DateTime? LastModified { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastModifiedBy { get; set; }

    }
}
