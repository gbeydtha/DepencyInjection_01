using System;
using System.Collections.Generic;
using System.Text;

namespace DepencyInjection_01
{
    public class ConsoleNotification
    {
        public void NotificationUserName(User user)
        {
            Console.WriteLine($"Username has benn changed to : {user.UserName}");
        }
    }
}
