using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIMD.TestTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Environment.Is64BitProcess)
                Console.WriteLine("Test is for 64 Bit");
            else
                Console.WriteLine("Test is for 32 Bit");

            Console.Write("Run Test (direct casting)");
            Test();
            Console.Write("Run Test B (casting with additional var)");
            TestB();

            Console.ReadLine();
        }

        static unsafe void Test()
        {
            var value = new Vector3(0, 0, -41);
            var a = *(System.Numerics.Vector3*)(&value);
            if (value.X == a.X && value.Y == a.Y && value.Z == a.Z)
                Console.WriteLine(".....Test is ok");
            else
                Console.WriteLine(".....Test fail");
        }

        static unsafe void TestB()
        {
            var value = new Vector3(0, 0, -41);
            var d = &value;
            var a = *(System.Numerics.Vector3*)d;
            if (value.X == a.X && value.Y == a.Y && value.Z == a.Z)
                Console.WriteLine(".....Test is ok");
            else
                Console.WriteLine(".....Test fail");
        }
    }
}
