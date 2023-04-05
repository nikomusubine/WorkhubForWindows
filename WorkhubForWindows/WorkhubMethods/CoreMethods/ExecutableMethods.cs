using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Serialization;
using WorkhubForWindows.Variant;

namespace WorkhubForWindows.WorkhubMethods.CoreMethods
{
    static class ExecutableMethods
    {
        public static List<Executable> Load()
        {
            List<Executable> exes = new List<Executable>();
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config"))
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml"))
                {
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan"))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan");

                    }
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows"))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWIndows");
                    }
                    if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config"))
                    {
                        Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config");
                    }
                    if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml"))
                    {
                        File.Copy(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml");
                        if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml"))
                        {
                            MessageBox.Show("Copied the Applications File to " + Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml" + ".",
                            "Information",
                            MessageBoxButton.OK, MessageBoxImage.Information);
                            File.Delete(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml");
                        }

                    }
                }
            }
            //元のConfigが存在しない

            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan");

            }
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWIndows");
            }
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config");
            }
            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml"))
            {
                return exes;
            }


            XmlSerializer serializer = new XmlSerializer(typeof(List<Executable>));

            var xmlSettings = new System.Xml.XmlReaderSettings
            {
                CheckCharacters = false,
            };


            using (var streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml", Encoding.UTF8))
            using (var xmlReader = System.Xml.XmlReader.Create(streamReader, xmlSettings))
            {
                exes = (List<Executable>)serializer.Deserialize(xmlReader);
            }

            return exes;
        }
        /// <summary>
        /// シリアライズしてセーブ 
        /// save with Serializing
        /// </summary>
        /// <returns></returns>
        public static void Save(List<Executable> executables)
        {
            XmlSerializer Serialize = new XmlSerializer(typeof(List<Executable>));
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config");
            }
            using (var Streamwriter = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Nikochan\\WorkhubForWindows\\Config\\Applications.xml", false, new System.Text.UTF8Encoding(false)))
            {
                Serialize.Serialize(Streamwriter, executables);
                Streamwriter.Flush();
            }
        }

    }
}
