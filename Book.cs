using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Book : Document
    {
        public int Pages {get; set;}

        public Book(int code, string title, int year, string genre, string position, string author_name, string author_surname, int pages) : base(code,title, year, genre, position, author_name, author_surname)
        {
            Pages = pages;
        }
    }
}
