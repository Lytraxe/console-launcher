using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Launcher
{
    class IStreamHandler
    {
        public static void AddObjects(string name, string path)
        {
            string nameFile = Global._nameFile;
            string pathFile = Global._pathFile;
            using (StreamWriter sw = File.AppendText(nameFile))
            {
                sw.WriteLine(name);
            }
            using (StreamWriter sw = File.AppendText(pathFile))
            {
                sw.WriteLine(path);
            }
        }
    }
}
