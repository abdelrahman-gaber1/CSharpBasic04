using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2_Interface
{
    
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }

        public bool AuthenticateUser()
        {
            if(this.Username == Username && this.Password == Password)
                return true;
            else return false;

        }

        public bool AuthorizeUser()
        {
            if(Role != null)
                return true;
            else
                return false;
        }
    }
}
