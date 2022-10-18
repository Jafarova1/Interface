using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IUser 
    {
        void Login(string username, string password);
        string SendEmail(string email);
    }
}
