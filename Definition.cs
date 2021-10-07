using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using WorkhubForWindows.Functions;
using System.Runtime.InteropServices;

namespace WorkhubForWindows
{
    public class Executable
    {
        public string Name;
        public string Path;
        public string Argments;
        public Point point;
    }

    public struct WorkhubWindowHandler
    {
        public WorkhubWindowHandler(int HWnd, string name)
        {
            hWnd = HWnd;
            Name = name;
        }
        public int hWnd { get; }
        public string Name { get; }
    }

    public class OwnFont
    {
        public OwnFont(string name, float size)
        {
            Name = name;
            Size = size;
        }

        public OwnFont()
        {

        }

        public string Name { get; set; }
        public float Size { get; set; }
    }
    
    public enum HomeMode
    {
        FullScreen=0,
        HalfHome=1,
    }

    public class Configure
    {

        public OwnFont font = new OwnFont("MS UI Gothic", 9);

        private string __backimgpath;
        public string backimgpath
        {
            get
            {
                return this.__backimgpath;
            }
            set
            {
                this.__backimgpath = value;
            }
        }
        private bool __LockWidget;
        public bool LockWidget
        {
            get
            {
                return this.__LockWidget;
            }
            set
            {
                this.__LockWidget = value;
                if (StaticClasses.AppStatus.Started)
                {
                    SendWidgetConfigChanged();
                }
            }
        }
        private string __Widgetbackimg;
        public string Widgetbackimg
        {
            get
            {
                return this.__Widgetbackimg;
            }
            set
            {
                this.__Widgetbackimg = value;
            }
        }
        private bool __ShowWidget;
        public bool ShowWidget
        {
            get
            {
                return this.__ShowWidget;
            }
            set
            {
                this.__ShowWidget = value;

                SendWidgetConfigChanged();
            }
        }
        private double __WidgetOpacity = 1;
        public double WidgetOpacity
        {
            get
            {
                return this.__WidgetOpacity;
            }
            set
            {
                __WidgetOpacity = value;
                SendWidgetConfigChanged();
            }
        }
        public int __WidgetForeColor = Color.FromArgb(0, 0, 0).ToArgb();
        public Color WidgetForeColor
        {
            get
            {
                return Color.FromArgb(__WidgetForeColor);
            }
            set
            {
                __WidgetForeColor = value.ToArgb();
                this.SendWidgetConfigChanged();
            }
        }
        private Point __WidgetSize = new Point(350, 350);
        public Point WidgetSize
        {
            get
            {
                return this.__WidgetSize;
            }
            set
            {
                __WidgetSize = value;
            }
        }
        private HomeMode __Homemode = HomeMode.HalfHome;
        public HomeMode Homemode
        {
            get
            {
                return this.__Homemode;
            }
            set
            {
                this.__Homemode = value;
            }
        }
        public string LogoffSound;
        public string ShutdownSound;



        [DllImport("User32.dll", EntryPoint = "PostMessage")]
        extern static Int32 PostMessage(Int32 hwnd, Int32 msg, Int32 wParam, Int32 lParam);

        public void SendConfigChanged()
        {
            foreach (WorkhubWindowHandler i in StaticClasses.WindowHandler.WindowHandlers)
            {
                PostMessage(i.hWnd, StaticClasses.WorkHubMessages.ConfigChanged, 0, 0);
            }
        }

        public void ApplyConfig()
        {
            this.SendConfigChanged();
        }

        private void SendWidgetConfigChanged()
        {
            foreach (WorkhubWindowHandler i in StaticClasses.WindowHandler.WindowHandlers)
            {
                if (i.Name == "Widget")
                {
                    PostMessage(i.hWnd, StaticClasses.WorkHubMessages.WidgetConfigChanged, 0, 0);
                }
            }
        }

        public void SaveConfig(Configure cfg)
        {
            XmlSerializer Serialize = new XmlSerializer(typeof(Configure));
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config\\"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Config");
            }
            using (var Streamwriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Config\\Config.xml", false, new System.Text.UTF8Encoding(false)))
            {
                Serialize.Serialize(Streamwriter, cfg);
                Streamwriter.Flush();
            }
            return;
        }

        public Configure LoadConfig()
        {
            Configure cfg = new Configure();
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Config");
            }
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config\\Config.xml"))
            {
                return cfg;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(Configure));

            var xmlSettings = new System.Xml.XmlReaderSettings
            {
                CheckCharacters = false,
            };
            using (var streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Config\\Config.xml", Encoding.UTF8))
            using (var xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings))
            {
                cfg = (Configure)serializer.Deserialize(xmlReader);
            }
            return cfg;
        }
    }

    public static class StaticClasses
    {
        public static List<Executable> Executables { get; set; } = new List<Executable>();
        public static string ConfigFoldor { get; set; }
        public static Configure Config { get; set; } = new Configure();
        public static class WorkHubMessages
        {
            public const int ConfigChanged = 0x2500;
            public const int AppListChanged = 0x2501;
            public const int WidgetConfigChanged = 0x2502;
            public const int ApplicationQuit = 0x2510;
        }

        public static class WindowHandler
        {
            public static List<WorkhubWindowHandler> WindowHandlers = new List<WorkhubWindowHandler>();
        }



        public static class AppStatus
        {
            public static bool Started = false;
        }

    }
}
