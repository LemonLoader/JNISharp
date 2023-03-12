namespace JNISharp.NativeInterface;

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal unsafe static class JVMImports
{
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern JNI.Result JNI_CreateJavaVM(out JavaVM* jvm, out JNIEnv* env, JavaVMInitArgs* args);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern JNI.Result JNI_GetDefaultJavaVMInitArgs(IntPtr argsPtr);

    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern JNI.Result JNI_GetCreatedJavaVMs(out JavaVM* jvm, int bufferLength, out int createdVMs);
}
