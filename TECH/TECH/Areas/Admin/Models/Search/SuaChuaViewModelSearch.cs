﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TECH.Areas.Admin.Models.Search
{
    public class SuaChuaViewModelSearch : PageViewModel
    {
       public string? name { get; set; }
       public int? loaiDV { get; set; }
        public int? UserId { get; set; }   
    }
}