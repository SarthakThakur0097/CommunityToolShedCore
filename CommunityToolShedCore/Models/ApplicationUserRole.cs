﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunityToolShedCore.Models
{
    public class ApplicationUserRole: IdentityUserRole<long>
    {
        public int Id { get; set; }
    }
}