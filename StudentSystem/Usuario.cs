using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    internal class Usuario
    {
            public string Type { get; set; }

            public string FullName { get; set; }

            public string Username { get; set; }

            public string Password { get; set; }

        public Usuario(string type, string fullName, string username, string password)
        {
            Type = type;
            FullName = fullName;
            Username = username;
            Password = password;
        }



    }
}
