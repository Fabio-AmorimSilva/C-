using System;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            var alice = new Person();

            bob.name = "Bob Smith";
            bob.dateOfBirth = new DateTime(2000,12,4);
            bob.FavoriteAncientWonder = WondersOfAncientWorld.ColussosOfRhodes;

            alice.name = "Alice";
            alice.dateOfBirth = new DateTime(1998, 3, 7);
            alice.FavoriteAncientWonder = WondersOfAncientWorld.LightHouseOfAlexandria;


            Console.WriteLine(bob.ToString());
            Console.WriteLine(
               format: "{0} was born on {1:dddd, d MMMM yyyy} and his favorite ancient wonder is {2}",
               arg0: bob.name,
               arg1: bob.dateOfBirth,
               arg2: bob.FavoriteAncientWonder);
            Console.WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy} and her favorite ancient wonder is {2}",
                arg0: alice.name,
                arg1: alice.dateOfBirth,
                arg2: alice.FavoriteAncientWonder);
        }
    }
}
