using System;

namespace DepencyInjection_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User("Abul");

            user.ChangeUserName("Abul Hasan"); 

            Console.ReadKey();
        }
    }
}
