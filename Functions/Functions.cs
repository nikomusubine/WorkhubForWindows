using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
using System.Security.Cryptography;

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
            public static void StartProcess(WorkhubForWindows.Executable executable, bool RunasAdmin)
            {
                Process Prs = new Process();

                Prs.StartInfo.FileName = executable.Path;
                Prs.StartInfo.Arguments = executable.Argments;
                Prs.StartInfo.UseShellExecute = RunasAdmin;
                Prs.StartInfo.WorkingDirectory = executable.CurrentDir;
                Prs.StartInfo.Verb = "RunAs";
                try
                {
                    Prs.Start();
                }
                catch (Exception)
                {

                }
            }
            public static int StartProcess(WorkhubForWindows.Executable executable)
            {
                Process Prs = new Process();
                Prs.StartInfo.FileName = executable.Path;
                Prs.StartInfo.Arguments = executable.Argments;
                Prs.StartInfo.WorkingDirectory = executable.CurrentDir;
                if (executable.RunasAdmin)
                {
                    Prs.StartInfo.Verb = "RunAs";
                    Prs.StartInfo.UseShellExecute = true;
                    try
                    {
                        Prs.Start();
                    }
                    catch (Exception)
                    {

                    }
                    return 0;
                }
                else
                {
                    Prs.StartInfo.UseShellExecute = false;
                    try
                    {
                        Prs.Start();
                    }
                    catch (System.ComponentModel.Win32Exception)
                    {
                        Prs.StartInfo.Verb = "RunAs";
                        Prs.StartInfo.UseShellExecute = true;
                        executable.RunasAdmin = true;

                        try
                        {
                            Prs.Start();
                        }
                        catch (Exception)
                        {

                        }
                    }
                    return (executable.RunasAdmin) ? 1 : 0;

                }

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
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    
                    using (var streamReader = new StreamReader(StaticClasses.ConfigPath + "Config\\Applications.xml", Encoding.UTF8))
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
                    if(!Directory.Exists(StaticClasses.ConfigPath + "Config\\"))
                    {
                        Directory.CreateDirectory(StaticClasses.ConfigPath + "Config");
                    }
                    using (var Streamwriter = new StreamWriter(StaticClasses.ConfigPath + "Config\\Applications.xml", false, new System.Text.UTF8Encoding(false)))
                    {
                        Serialize.Serialize(Streamwriter, executables);
                        Streamwriter.Flush();
                    }
                }
            }
        }
        
        public static class WinAPIFuncs
        {
            [DllImport("User32.dll", EntryPoint = "PostMessage")]
            public extern static Int32 PostMessage(Int32 hwnd, Int32 msg, Int32 wParam, Int32 lParam);
            [DllImport("user32.dll")]
            public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);
            public static Icon GetSieldIcon(bool smallSize)
            {
                return SieldIcon.GetShieldIcon(smallSize);
            }
            private static class SieldIcon
            {
                private const int MAX_PATH = 260;
                private const uint SIID_SHIELD = 0x00000004D;
                private const uint SHGSI_ICON = 0x000000100;
                private const uint SHGSI_LARGEICON = 0x000000000;
                private const uint SHGSI_SMALLICON = 0x000000001;

                [StructLayoutAttribute(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
                private struct SHSTOCKICONINFO
                {
                    public uint cbSize;
                    public IntPtr hIcon;
                    public int iSysIconIndex;
                    public int iIcon;
                    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
                    public string szPath;
                }

                [DllImport("shell32.dll", SetLastError = false)]
                private static extern int SHGetStockIconInfo(uint siid,
                    uint uFlags, ref SHSTOCKICONINFO sii);

                /// <summary>
                /// UAC盾アイコンを取得する
                /// </summary>
                /// <param name="smallSize">小さいアイコン(16x16)を取得する時はtrue。
                /// 大きいいアイコン(32x32)を取得する時はfalse。</param>
                /// <returns>UAC盾アイコンのIconオブジェクト。
                /// Windows Vista未満のOSの時はnullを返す。</returns>
                public static Icon GetShieldIcon(bool smallSize)
                {
                    //Windows Vista以上か確認する
                    if (Environment.OSVersion.Platform != PlatformID.Win32NT ||
                        Environment.OSVersion.Version.Major < 6)
                    {
                        return null;
                    }

                    SHSTOCKICONINFO sii = new SHSTOCKICONINFO();
                    sii.cbSize = (uint)Marshal.SizeOf(typeof(SHSTOCKICONINFO));
                    //盾アイコンを取得する
                    int res = SHGetStockIconInfo(SIID_SHIELD,
                        SHGSI_ICON | (smallSize ? SHGSI_SMALLICON : SHGSI_LARGEICON),
                        ref sii);

                    //失敗した時は例外をスローする
                    if (res != 0)
                    {
                        Marshal.ThrowExceptionForHR(res);
                    }

                    //Iconオブジェクトを作成する
                    return Icon.FromHandle(sii.hIcon);
                }
            }
        }
        
        public static class WinMsgFuncs
        {
            public static void AppClose()
            {
                foreach (var i in StaticClasses.WindowHandler.WindowHandlers)
                {
                    WinAPIFuncs.PostMessage(i.hWnd, StaticClasses.WorkHubMessages.ApplicationQuit, 0, 0);
                }
            }
        }

        public static class Hash
        {
            public static string GetHashString<T>(string text) where T : HashAlgorithm, new()
            {
                // 文字列をバイト型配列に変換する
                byte[] data = Encoding.UTF8.GetBytes(text);

                // ハッシュアルゴリズム生成
                var algorithm = new T();

                // ハッシュ値を計算する
                byte[] bs = algorithm.ComputeHash(data);

                // リソースを解放する
                algorithm.Clear();

                // バイト型配列を16進数文字列に変換
                var result = new StringBuilder();
                foreach (byte b in bs)
                {
                    result.Append(b.ToString("X2"));
                }
                return result.ToString();
            }
        }
    }
}
