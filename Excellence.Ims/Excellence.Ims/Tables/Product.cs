﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Excellence.Ims
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<Item> Item { get; set; }
    }
}
