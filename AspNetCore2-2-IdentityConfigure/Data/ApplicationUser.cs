﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace AspNetCore2_2_IdentityConfigure.Data
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string FullName { get; set; }
    }
}
