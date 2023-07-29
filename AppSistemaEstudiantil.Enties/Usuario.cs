using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSistemaEstudiantil.Entities
{
    public class Usuario
    {
        public string Access { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string ImageName { get; set; }

        public Usuario(string access, string fullName, string username, string password,string email,string imagename)
        {
            Access = access;
            FullName = fullName;
            Username = username;
            Password = password;
            Email = email;
            ImageName = imagename;
        }
    }
}
