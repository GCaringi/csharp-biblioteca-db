using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    public class Document
    { 
        public int Code { get; set; }
        public string? Title { get; set; }
        public int Year { get; }
        public string Genre { get; set; }
        public bool isLoaned { get; set; }
        public string Position { get; set; }

        protected Document(int code, string title, int year, string genre, string position)
        {
            Code = code;
            Title = title;
            Year = year;
            Genre = genre;
            isLoaned = false;
            Position = position;
        }

        public override string ToString()
        {
            return $"Code: {Code} Title: {Title} Year: {Year} Genre: {Genre} isLoaned: {isLoaned} Position: {Position}";
        }
    }

   
}
