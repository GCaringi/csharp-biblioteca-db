using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Users : Person
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }

        public Users(string name, string surname, string? email, string? password, string? phoneNumber) : base(name, surname)
        {
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }   
}
