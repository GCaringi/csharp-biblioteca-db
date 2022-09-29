using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    public class Book : Document
    {
        public int Pages {get; set;}

        public Book(int code, 
                string title, 
                int year, 
                string genre, 
                string position,
                int pages) : 
                base(code,title, year, genre, position)
        {
            Pages = pages;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + Pages + " pages";
        }
    }
}
