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

namespace WorkhubForWindows
{
    public class Executable
    {
        public string Name;
        public string Path;
        public string Argments;
        public Point point;
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

    }

    public class Configure
    {
        
        public OwnFont font = new OwnFont("MS UI Gothic", 9); 
        public string backimgpath { get; set; }
        public bool LockWidget { get; set; }
        public string Widgetbackimg { get; set; }
        public bool ShowWidget { get; set; }
        public HomeMode Homemode { get; set; }
        public string LogoffSound;
        public string ShutdownSound;



        

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

        
    }
}
