using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge.Entities
{
    public class Client
    {
        
        public Client ()
        {

        }

        public Client (string name, string email, DateTime birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public string Name { get; set; }

        public string Email { get; set; }

        public DateTime BirthDate { get; set; }
    }
}