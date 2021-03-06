// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Microsoft.Win32.SafeHandles
{
    // Class of critical handle which uses only -1 as an invalid handle.
    public abstract class CriticalHandleMinusOneIsInvalid : CriticalHandle
    {
        protected CriticalHandleMinusOneIsInvalid()
            : base(new IntPtr(-1))
        {
        }

        public override bool IsInvalid => handle == new IntPtr(-1);
    }
}
