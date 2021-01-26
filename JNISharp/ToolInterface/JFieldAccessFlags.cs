﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.ToolInterface
{
    public enum JFieldAccessFlags
    {
        Public = 0x0001,
        Private = 0x0002,
        Protected = 0x0004,
        Static = 0x0008,
        Final = 0x0010,
        Volatile = 0x0040,
        Transient = 0x0080,
        Synthetic = 0x1000,
        Enum = 0x4000
    }
}
