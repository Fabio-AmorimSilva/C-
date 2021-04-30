using System;

namespace names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"Adam", "Barry", "Charlie", "Fabio", "John", "Johanna"};

            foreach (var name in names){
                Console.WriteLine($"{name} has {name.Length} characteres");
                
            }

        }
    }
}
