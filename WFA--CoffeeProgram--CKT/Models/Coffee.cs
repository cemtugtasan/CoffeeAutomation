﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA__CoffeeProgram__CKT.Models
{
    public class Coffee
    {
        public string Name { get; set; }
        public SizeType Size { get; set; }
        public decimal Price { get; set; }
        public string ImagePath { get; set; }
    }
}
