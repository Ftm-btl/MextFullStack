﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStackSaaS.Domain.Common
{
    public interface ICreatedByEntity
    {
        DateTimeOffset CreatedOn { get; set; }
        string CreatedByUserId { get; set; }
    }
}
