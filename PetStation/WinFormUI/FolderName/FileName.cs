using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormUI.FolderName
{
    public static class FileName
    {
        public static string InfoForFileName(string fileRoad)
        {
            string result;

            result = Path.GetFileName(fileRoad);

            return result;
        }
    }
}
