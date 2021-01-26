﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.ToolInterface
{
    public static partial class JVMTI
    {
        public enum Error
        {
            None = 0,
            InvalidThread = 10,
            InvalidThreadGroup = 11,
            InvalidPriority = 12,
            ThreadNotSuspended = 13,
            ThreadSuspended = 14,
            ThreadNotAlive = 15,
            InvalidObject = 20,
            InvalidClass = 21,
            ClassNotPrepared = 22,
            InvalidMethodID = 23,
            InvalidLocation = 24,
            InvalidFieldID = 25,
            NoMoreFrames = 31,
            OpaqueFrame = 32,
            TypeMismatch = 34,
            InvalidSlot = 35,
            Duplicate = 40,
            NotFound = 41,
            InvalidMonitor = 50,
            NotMonitorOwner = 51,
            Interrupt = 52,
            InvalidClassFormat = 60,
            CircularClassDefinition = 61,
            FailsVerification = 62,
            UnsupportedRedefinitionMethodAdded = 63,
            UnsupportedRedefinitionSchemaChanged = 64,
            InvalidTypeState = 65,
            UnsupportedRedefinitionHierarchyChanged = 66,
            UnsupportedRedefinitionMethodDeleteted = 67,
            UnsupportedVersion = 68,
            NamesDontMatch = 69,
            UnsupportedRedefinitionClassModifiersChanged = 70,
            UnsupportedRedefinitionMethodModifiersChanged = 71,
            UnmodifiableClass = 79,
            NotAvailable = 98,
            MustPossessCapability = 99,
            NullPointer = 100,
            AbsentInformation = 101,
            InvalidEventType = 102,
            IllegalArgument = 103,
            NativeMethod = 104,
            ClassLoaderUnsupported = 106,
            OutOfMemory = 110,
            AccessDenied = 111,
            WrongPhase = 112,
            Internal = 113,
            UnattachedThread = 115,
            InvalidEnvironment = 116
        }
    }
}
