﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contractor.Models
{
    public class Role : ITimeBound
    {
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
