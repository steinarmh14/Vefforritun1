using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pro3.Models
{
    public class NewsViewModel
    {
        public NewsViewModel()
        {
            DateCreated = DateTime.Now;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "Title required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Text required")]
        public string Text { get; set; }

        public DateTime DateCreated { get; set; }

        [Required(ErrorMessage = "Category required")]
        public string Category { get; set; }
    }
}