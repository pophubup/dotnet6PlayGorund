﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zNpgsqlClient
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
