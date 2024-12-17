using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Scip;

public sealed class Var : SafeHandle
{
    internal Var(nint invalidHandleValue, bool ownsHandle)
        : base(invalidHandleValue, ownsHandle)
    {
    }

    public override bool IsInvalid => handle == default;

    protected override bool ReleaseHandle()
    {
        throw new NotImplementedException();
    }
}
