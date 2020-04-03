using System;
using System.Collections.Generic;
using System.Text;

namespace DepencyInjection_01
{
    public class User
    {
        private ConsoleNotification _consoleNotification; 
        public User(string username)
        {
            UserName = username;
            _consoleNotification = new ConsoleNotification(); 
        }
        public string UserName { get; private set; }

        public void ChangeUserName (string newUserName)
        {
            UserName = newUserName;
            _consoleNotification.NotificationUserName(this); 
        }
    }

}
