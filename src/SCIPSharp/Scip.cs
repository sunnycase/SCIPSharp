using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Scip;

public sealed class Scip : SafeHandle
{
    public Scip()
        : base(Native.SCIPcreate(), true)
    {
    }

    public override bool IsInvalid => handle == default;

    protected override bool ReleaseHandle() =>
        Native.SCIPfree(ref handle) == RetCode.Okay;
}
