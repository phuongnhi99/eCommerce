﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
