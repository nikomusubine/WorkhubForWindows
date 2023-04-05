using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkhubForWindows
{
    public class NativeMethods
    {
        public static class ShieldIcon
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
            public static Icon? GetShieldIcon()
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
                    SHGSI_ICON | (false ? SHGSI_SMALLICON : SHGSI_LARGEICON),
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
}
