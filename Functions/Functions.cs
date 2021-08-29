using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;

namespace WorkhubForWindows
{
    namespace Functions
    {
        public static class Application
        {
            /// <summary>
            /// プロセスの開始
            /// Start Process
            /// </summary>
            /// <param name="executable"></param>
            /// <param name="RunasAdmin"></param>
            static void StartProcess(WorkhubForWindows.Executable executable, bool RunasAdmin)
            {
                Process Prs = new Process();
                Prs.StartInfo.FileName = executable.Path;
                Prs.StartInfo.Arguments = executable.Argments;
                Prs.StartInfo.UseShellExecute = RunasAdmin;
                Prs.Start();
            }
        }

        public static class Config
        {
            public static class Applications
            {
                /// <summary>
                /// デシリアライズして読み込み
                /// Load with Deserializing
                /// </summary>
                /// <returns></returns>

                public static List<Executable> Load()
                {
                    List<Executable> exes = new List<Executable>();
                    if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml"))
                    {
                        return exes;
                    }
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Executable>));
                    
                    var xmlSettings = new System.Xml.XmlReaderSettings
                    {
                        CheckCharacters = false,
                    };
                    using (var streamReader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml", Encoding.UTF8))
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
                    
                    using (var Streamwriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml", false, new System.Text.UTF8Encoding(false)))
                    {
                        Serialize.Serialize(Streamwriter, executables);
                        Streamwriter.Flush();
                    }
                }
            }
        }
    }
}
