using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Launcher
{
    class AppHandeler
    {

        public static void LaunchFile(string path)
        {
            try
            {
                Process.Start(path);
                Responses.SystemResponse("Application Launched successfully.");
                Responses.UserResponse(false);
            }
            catch (Exception e)
            {
                Responses.SystemResponse("Failed to Open file.");
                Responses.UserResponse(false);
            } 
        }
    }
}
