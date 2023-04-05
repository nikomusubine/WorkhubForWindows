using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media.Media3D;

namespace WorkhubForWindows.Variant
{
    public class Executable
    {
        public Executable(string name, string path, string currentDir, string args)
        {
            Name = name;
            Path = path;
            Arguments = args;
            RunasAdmin = false;
            IconPath = "";
            CurrentDir = currentDir;
        }

        public Executable(string name, string path, string currentDir, string args, bool runasAdmin, string iconPath)
        {
            Name = name;
            Path = path;
            Arguments = args;
            RunasAdmin = runasAdmin;
            IconPath = iconPath;
            CurrentDir = currentDir;
        }

        public Executable(string name, string path, string currentDir, string args, string iconPath)
        {
            Name = name;
            Path = path;
            Arguments = args;
            RunasAdmin = false;
            IconPath = iconPath;
            CurrentDir = currentDir;
        }
        public Executable(string name, string path, string currentDir, string args, bool runasAdmin)
        {
            Name = name;
            Path = path;
            Arguments = args;
            RunasAdmin = runasAdmin;
            IconPath = "";
            CurrentDir = currentDir;
        }
        public Executable(string name, string path, string args, string currentDir, string iconPath, bool runasAdmin)
        {
            Name = name;
            Path = path;
            Arguments = args;
            RunasAdmin = runasAdmin;
            IconPath = iconPath;
            CurrentDir = currentDir;
        }

        public Executable(Executable executable)
        {
            Name = executable.Name;
            Path = executable.Path;
            Arguments = executable.Arguments;
            RunasAdmin = executable.RunasAdmin;
            IconPath = executable.IconPath;
            CurrentDir = executable.CurrentDir;
        }

        public Executable()
        {
            Name = "";
            Path = "";
            Arguments = "";
            CurrentDir = "";
            IconPath = "";
            RunasAdmin = false;
        }
        public string Name { get; set; }
        public string Path { get; set; }
        public string Arguments { get; set; }
        public string CurrentDir { get; set; }
        public string IconPath { get; set; }

        public Bitmap IconImage { get
            {
                //IconPath指定なし
                if (IconPath == "" || IconPath == null)
                {
                    Icon? ico = Icon.ExtractAssociatedIcon(this.Path);
                    if(ico == null)
                    {
                        throw new NullReferenceException(nameof(IconPath));
                    }
                        
                    Bitmap bitmap=ico.ToBitmap();
                    if (this.RunasAdmin)
                    {
                        //盾アイコン取得
                        Icon? Shield = NativeMethods.ShieldIcon.GetShieldIcon();
                        if (Shield != null)
                        {
                            //合成
                            Graphics graphics = Graphics.FromImage(bitmap);
                            float Devision = 2;
                            Image shield = new Bitmap(Shield.ToBitmap(), new Size((int)(bitmap.Width / Devision), (int)(bitmap.Height / Devision)));
                            graphics.DrawImage(shield, bitmap.Width - (bitmap.Width / Devision), bitmap.Height - (bitmap.Height / Devision), shield.Width, shield.Height);
                            graphics.Dispose();
                        }
                    }
                    return bitmap;
                }
                else //IconPath指定
                {
                    Bitmap bmp = (Bitmap)Bitmap.FromFile(IconPath);
                    return bmp;
                }

            } }
        public bool RunasAdmin { get; set; }
    }
}
