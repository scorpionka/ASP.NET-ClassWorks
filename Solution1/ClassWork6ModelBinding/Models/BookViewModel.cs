using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassWork6ModelBinding.Models
{
    public class BookViewModel
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int Year { get; set; }
    }
}