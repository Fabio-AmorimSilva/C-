using System;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Type\tBytes\tMin\t\tMax");
           Console.WriteLine("sbyte:\t" + sizeof(sbyte) + "\t" + sbyte.MinValue + "\t\t" + sbyte.MaxValue);
           Console.WriteLine("byte:\t" + sizeof(byte) + "\t"  + byte.MinValue  + "\t\t" + byte.MaxValue);
           Console.WriteLine("short:\t" + sizeof(short) + "\t" + short.MinValue + "\t\t" + short.MaxValue);
           Console.WriteLine("ushort:\t" + sizeof(ushort) + "\t" + ushort.MinValue + "\t\t" + ushort.MaxValue);
           Console.WriteLine("int:\t" + sizeof(int) + "\t" + int.MinValue + "\t\t" + int.MaxValue);
           Console.WriteLine("uint:\t" + sizeof(uint) + "\t" + uint.MinValue + "\t\t" + uint.MaxValue);
           Console.WriteLine("long:\t" + sizeof(long) + "\t" + long.MinValue + "\t\t" + long.MaxValue);
           Console.WriteLine("ulong:\t" + sizeof(ulong) + "\t" + ulong.MinValue + "\t\t" + ulong.MaxValue);
           Console.WriteLine("float:\t" + sizeof(float) + "\t" + float.MinValue + "\t\t" + float.MaxValue);
           Console.WriteLine("double:\t" + sizeof(double) + "\t" + double.MinValue + "\t\t" + double.MaxValue);
           Console.WriteLine("decimal:" + sizeof(decimal) + "\t" + decimal.MinValue + "\t\t" + decimal.MaxValue);


        }
    }
}
