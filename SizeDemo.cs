using System;

namespace CSharpBasics
{
    class SizeDemo
    {
        public void PrintSizeOf()
        {
            Console.WriteLine($"Size of bool :{sizeof(bool)} bytes");
            Console.WriteLine($"Size of byte :{sizeof(byte)} bytes");
            Console.WriteLine($"Size of sbyte :{sizeof(sbyte)} bytes");
            Console.WriteLine($"Size of char :{sizeof(char)} bytes");
            Console.WriteLine($"Size of decimal :{sizeof(decimal)} bytes");
            Console.WriteLine($"Size of double :{sizeof(double)} bytes");
            Console.WriteLine($"Size of float :{sizeof(float)} bytes");
            Console.WriteLine($"Size of int :{sizeof(int)} bytes");
            Console.WriteLine($"Size of uint :{sizeof(uint)} bytes");
            Console.WriteLine($"Size of long :{sizeof(long)} bytes");
            Console.WriteLine($"Size of ulong :{sizeof(ulong)} bytes");
            Console.WriteLine($"Size of short :{sizeof(short)} bytes");
            Console.WriteLine($"Size of ushort :{sizeof(ushort)} bytes");
            
        }
    }
}