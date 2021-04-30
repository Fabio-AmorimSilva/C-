using System;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount.interestRate = 0.012M; //store a shared value
            var jonesAccount = new BankAccount();
            jonesAccount.accountName = "Mrs. Jones";
            jonesAccount.balance = 2400;

            var bob = new Person();
            var alice = new Person();

            bob.name = "Bob Smith";
            bob.dateOfBirth = new DateTime(2000,12,4);
            bob.FavoriteAncientWonder = WondersOfAncientWorld.ColussosOfRhodes;
            bob.children.Add(new Person{name = "Alfred"});
            bob.children.Add(new Person{name = "Zoe"});

            alice.name = "Alice";
            alice.dateOfBirth = new DateTime(1998, 3, 7);
            alice.FavoriteAncientWonder = WondersOfAncientWorld.LightHouseOfAlexandria;
            alice.children.Add(new Person{name = "Bob"});
            alice.children.Add(new Person{name = "Maria"});

            Console.WriteLine(bob.ToString());
            Console.WriteLine(
               format: "{0} was born on {1:dddd, d MMMM yyyy} and his favorite ancient wonder is {2}",
               arg0: bob.name,
               arg1: bob.dateOfBirth,
               arg2: bob.FavoriteAncientWonder);
            
            for(int i = 0; i < bob.children.Count; i++){
                Console.WriteLine($"Bob children {i+1} {bob.children[i].name}");

            }

            Console.WriteLine(
                format: "{0} was born on {1:dddd, d MMMM yyyy} and her favorite ancient wonder is {2}",
                arg0: alice.name,
                arg1: alice.dateOfBirth,
                arg2: alice.FavoriteAncientWonder);

            for(int i = 0; i < alice.children.Count; i++){
                Console.WriteLine($"Alice children {i+1} {alice.children[i].name}");

            }
        }
    }
}
