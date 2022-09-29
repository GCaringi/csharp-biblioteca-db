using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Dvd : Document
    {
        public int Duration { get; set; }

        public Dvd(int code, string title, int year, string genre, string position, string author_name, string author_surname, int duration) : base(code, title, year, genre, position, author_name, author_surname)
        {
            Duration = duration;
        }
    }
}
