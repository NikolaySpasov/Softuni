using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class DirectoryInfo
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmtyLine();
            int initialIdentation = path.Split('\\').Length;
            Queue<string> subFolders = new Queue<string>();
            subFolders.Enqueue(path);
        }
    }
}
