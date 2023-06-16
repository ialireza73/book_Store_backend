using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace book_Store_backend.Data
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }

        public string description { get; set; }
        public int amounth{get;set;}
    }
}