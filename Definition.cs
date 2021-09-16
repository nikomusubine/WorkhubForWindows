using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Point point;
    }

    public static class StaticClasses
    {
        public static List<Executable> Executables = new List<Executable>();
        public static string ConfigFoldor;

        public static class Config
        {
            public static Font font = new Font("MS UI Gothic", 9);
            public static string backimgpath;
        }
    }
}
