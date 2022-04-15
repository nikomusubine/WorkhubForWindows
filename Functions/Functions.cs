﻿using System;
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
                Prs.StartInfo.Verb = "RunAs";
                Prs.Start();
            }
            public static void StartProcess(WorkhubForWindows.Executable executable)
            {
                Process Prs = new Process();
                Prs.StartInfo.FileName = executable.Path;
                Prs.StartInfo.Arguments = executable.Argments;
                if (executable.RunasAdmin)
                {
                    Prs.StartInfo.Verb = "RunAs";
                    Prs.StartInfo.UseShellExecute = true;
                    Prs.Start();
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
                        Prs.Start();
                    }
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
                    if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Config");
                    }
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
                    if(!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Config\\"))
                    {
                        Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "Config");
                    }
                    using (var Streamwriter = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "Config\\Applications.xml", false, new System.Text.UTF8Encoding(false)))
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

       
    }
}
