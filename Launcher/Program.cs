using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Launcher
{
    class Program
    {

        public static string[] fileNames;
        public static string[] paths;

        static void Main()
        {
            InitializeElements();
            Responses.SystemResponse("Type 'start' , 'new' or 'exit'");
            CheckForInput();
            
            //Responses.SystemResponse();
        }

        static void InitializeElements()
        {
            string nameFile = Global._nameFile;
            string pathFile = Global._pathFile;
            string directoryPath = Global._directoryPath;

            if(!Directory.Exists(directoryPath))
            {
                DirectoryInfo di = Directory.CreateDirectory(directoryPath);
                Responses.SystemResponse("Directory Successfuly created");
            }
            
            if (File.Exists(nameFile) && File.Exists(pathFile))
            {
                fileNames = File.ReadAllLines(nameFile);
                paths = File.ReadAllLines(pathFile);
            }
            else
            { StreamWriter sw = File.CreateText(nameFile);
              sw = File.CreateText(pathFile);
            }
        }

        static void CheckForInput()
        {

            string input = Responses.UserResponse(true);
            if(input == "new")
            {
                ProcceedAdding();
            }
            if(input == "exit")
            {
                Close();
            }
            if (input == null)
            {
                Responses.SystemResponse("Choose something you nerd.");
                Responses.UserResponse(false);
                Close();
            }
            else if (input == "start")
            {
                WriteFileNames();
                Responses.SystemResponse("Enter the index number: ");
                string input2 = Responses.UserResponse(true);
                int num = Convert.ToInt32(input2);
                CalculateLaunchData(num);
            }
        }

        static void ProcceedAdding()
        {
            Responses.SystemResponse("Enter The Display name :");
            string name = Responses.UserResponse(false);
            Responses.SystemResponse("Enter The Path (case senstitive) :");
            string path = Responses.UserResponse(false);

            IStreamHandler.AddObjects(name, path);

            Responses.SystemResponse("Successfully added that.");
            Main();
            
        }

        static void WriteFileNames()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (fileNames != null)
            {
                for (int i = 0; i < fileNames.Length; i++)
                {
                    Console.WriteLine(i + ". " + fileNames[i] + "          " + paths[i]);
                }
            }
            else { Responses.SystemResponse("Name list Empty, try to add more Items."); }
        }

        static void CalculateLaunchData(int index)
        {
            try
            {
                string finalPath = paths[index];
                //Responses.SystemResponse(finalPath);
                //Responses.UserResponse(false);
                AppHandeler.LaunchFile(finalPath);
            }
            catch (Exception e)
            {
                Responses.SystemResponse("An Error occured. Application will now close");
                Responses.UserResponse(false);
                Close();
            }
            
        }

        static void Close()
        {
            Environment.Exit(0);
        }

    }
}
