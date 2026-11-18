using System;
using System.Runtime.InteropServices;

namespace Somelib.Raw;

using Somelib;
using Somelib.Diplomat;

[StructLayout(LayoutKind.Sequential)]
internal partial struct DiplomatOptionVoid
{
    public DiplomatBool IsSome;
}