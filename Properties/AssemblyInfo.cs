﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// アセンブリに関する一般情報は以下の属性セットをとおして制御されます。
// 制御されます。アセンブリに関連付けられている情報を変更するには、
// これらの属性値を変更します。
[assembly: AssemblyTitle("WorkhubForWindows")]
[assembly: AssemblyDescription("")]
#if Debug
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Nikochan")]
[assembly: AssemblyProduct("WorkhubForWindows")]
[assembly: AssemblyCopyright("Copyright© 2022 Niko Musubine")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// ComVisible を false に設定すると、このアセンブリ内の型は COM コンポーネントから
// 参照できなくなります。COM からこのアセンブリ内の型にアクセスする必要がある場合は、
// その型の ComVisible 属性を true に設定してください。
[assembly: ComVisible(false)]

// このプロジェクトが COM に公開される場合、次の GUID が typelib の ID になります
[assembly: Guid("beb1e7a5-d6d0-4e7f-bf2e-eb2be704cb8a")]

// アセンブリのバージョン情報は、以下の 4 つの値で構成されています:
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号
//      リビジョン
//
// すべての値を指定するか、次を使用してビルド番号とリビジョン番号を既定に設定できます
// 既定値にすることができます:
// [assembly: AssemblyVersion("1.0.*")]

// WorkhubForWindws バージョン2.0より、命名規則は以下のようになります。
//
//      メジャー バージョン
//      マイナー バージョン
//      ビルド番号: SnapshotまたはDebugは0、Releaseは1以上の値。AssemblyInfoよりこちらの値が優先されます。
//      リビジョン: n回目のビルド
//
[assembly: AssemblyVersion("2.0.0.1")]
[assembly: AssemblyFileVersion("2.0.0.1")]
