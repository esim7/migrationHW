﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public class WorkOffice 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Boss> Bosses { get; set; }
    }
}
