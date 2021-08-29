using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkhubForWindows
{
    public class Executable
    {
        public string Name;
        public string Path;
        public string Argments;
    }

    public static class StaticClasses
    {
        public static List<Executable> Executables = new List<Executable>();
        public static string ConfigFoldor;
    }
}
