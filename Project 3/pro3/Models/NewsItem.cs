﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pro3.Models
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public string Category { get; set; }
    }
}