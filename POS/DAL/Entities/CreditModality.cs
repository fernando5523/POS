﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class CreditModality
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Days { get; set; }
        public int IdUser { get; set; }
    }
}
