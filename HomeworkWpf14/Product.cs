﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWpf14
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public Categories Category { get; set; }
    }
}
