using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Scip;

internal partial class Native
{
    public const string LibraryName = "libscip";

    [DllImport(LibraryName)]
    public static extern unsafe RetCode SCIPcreate([Out] out IntPtr scip);

    [DllImport(LibraryName)]
    public static extern unsafe RetCode SCIPfree([In, Out] ref IntPtr scip);

    public static IntPtr SCIPcreate()
    {
        SCIPcreate(out var scip).ThrowIfFailed();
        return scip;
    }
}
