﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shoppingstore.Models
{
    public class Item
    {
        public  string Title { get; set; }
        public Category Category { get; set; }
    }
}