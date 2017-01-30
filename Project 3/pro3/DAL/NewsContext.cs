using pro3.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace pro3.DAL
{
    public class NewsContext : DbContext
    {
        public NewsContext()
            : base ("NewsContext")
        {

        }
        public DbSet<NewsItem> News { get; set; }
    }
}