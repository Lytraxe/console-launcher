using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    public class Responses
    {

        public static string UserResponse(bool lower)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            string userResponse = Console.ReadLine();
            if (lower)
            {
                userResponse = userResponse.ToLower();
            }
            return userResponse;
            
        }

        public static void SystemResponse(string response)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(response);
        }
    }
}
