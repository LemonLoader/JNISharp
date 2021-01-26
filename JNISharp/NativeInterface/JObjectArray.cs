﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JNISharp.NativeInterface
{
    public class JObjectArray<T> : JObject, IEnumerable<T> where T : JObject, new()
    {
        public int Length => JNI.GetArrayLength(this);

        public T this[int index]
        {
            get => JNI.GetObjectArrayElement(this, index);
            set => JNI.SetObjectArrayElement(this, index, value);
        }

        public void SetElement(T value, int index)
        {
            JNI.SetObjectArrayElement(this, index, value);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < this.Length; i++)
            {
                yield return JNI.GetObjectArrayElement(this, i);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
