﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDMS.Data
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
       // public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
