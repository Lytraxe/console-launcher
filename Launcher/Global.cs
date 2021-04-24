using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Global
    {
        public static string _appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public static string _directoryPath = _appData + "\\CLauncher";
        public static string _nameFile = _directoryPath + "\\names.dat";
        public static string _pathFile = _directoryPath + "\\paths.dat";
    }
}
