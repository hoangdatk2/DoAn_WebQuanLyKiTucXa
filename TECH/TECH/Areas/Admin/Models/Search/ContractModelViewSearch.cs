﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TECH.Areas.Admin.Models.Search;

namespace TECH.Areas.Admin.Models.Search
{
    public class ContractModelViewSearch : PageViewModel
    {
        public string? name { get; set; }
        public int? status { get; set; }
    }
}
