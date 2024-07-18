using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2_Interface
{

     enum Role
    {
        Admin = 1  , User =2 , Guest =3
    }
    internal interface IAuthenticationService
    {
        public string Username { get; set; }

        public string Password { get; set; }    

        public Role Role { get; set; }
         
        public bool AuthenticateUser();
        public bool AuthorizeUser();


    }
}
