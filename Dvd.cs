using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca_db
{
    public class Dvd : Document
    {
        public int Duration { get; set; }

        public Dvd(int code, string title, int year, string genre, string position, int duration) : base(code, title, year, genre, position)
        {
            Duration = duration;
        }
    }
}
