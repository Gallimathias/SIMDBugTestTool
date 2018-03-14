using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SIMD.TestTool
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct Vector3
    {
        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public float X;
        public float Y;
        public float Z;
    }
}
