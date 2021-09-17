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
        public string Name { get; set; }
        public string Path { get; set; }
        public string Argments { get; set; }
        public Point point { get; set; }
    }

    public static class StaticClasses
    {
        public static List<Executable> Executables { get; set; } = new List<Executable>();
        public static string ConfigFoldor { get; set; }

        public static class Config
        {
            public static Font font { get; set; } = new Font("MS UI Gothic", 9);
            public static string backimgpath { get; set; }
            public static bool LockWidget { get; set; }
            public static string Widgetbackimg { get; set; }
        }
    }
}
