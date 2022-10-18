using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Test : IUser
    {
        public void Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public string SendEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
