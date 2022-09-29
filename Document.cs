using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Document
    { 
        public int Code { get; set; }
        public string? Title { get; set; }
        public int Year { get; }
        public string Genre { get; set; }
        public bool isLoaned { get; set; }
        public string Position { get; set; }
        public Person Author { get; set; }

        protected Document(int code, string title, int year, string genre, string position, string author_name, string author_surname)
        {
            Code = code;
            Title = title;
            Year = year;
            Genre = genre;
            isLoaned = false;
            Position = position;
            Author = new Person(author_name, author_surname);
        }

    }

   
}
