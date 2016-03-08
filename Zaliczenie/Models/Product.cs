﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zaliczenie.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
    }
}