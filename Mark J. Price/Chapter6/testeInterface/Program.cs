using System;

namespace testeInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person{ name = "Harry" };
            var mary = new Person{ name = "Mary"};
            var jill = new Person{ name = "Jill"};

             var baby1 = mary.procreateWith(harry);

             var baby2 = Person.procreate(harry, jill);

             var baby3 = mary * harry;

             Person[] people = {
                 new Person{ name = "Simon"},
                 new Person{ name = "Jenny"},
                 new Person{ name = "Adam"},
                 new Person{ name = "Richard"}

             };

             var dvd = new DvdPlayer();

             dvd.play();
             dvd.pause();
             dvd.stop();
            

             Console.WriteLine("Initial list of people: ");
             foreach(var person in people){
                 Console.WriteLine($"{person.name}");

             }

             Console.WriteLine("Use Person's IComparable implementation to sort: ");
             Array.Sort(people);
             foreach(var person in people){
                 Console.WriteLine($"{person.name}");
             }

             Console.WriteLine("Use PersonComparer's IComparer implementation to sort: ");
             Array.Sort(people, new PersonComparer());
             foreach(var person in people){
                 Console.WriteLine($"{person.name}");

             }

             Employee john = new Employee{
                 name = "John Jones",
                 dateOfBirth = new DateTime(1990, 7 , 28)

             };

             john.employeeCode = "JJ001";
             john.hireDate = new DateTime(2014, 11, 23);

             Console.WriteLine($"Person ToString: {john.ToString()}");

             try{

                john.timeTravel(new DateTime(1999, 12, 31));
                john.timeTravel(new DateTime(1842, 7, 25));
                

             }catch(PersonException exPerson){
                 Console.WriteLine(exPerson.Message);

             }

             //john.writeToConsole();

             //Console.WriteLine($"{john.name} was hired on {john.hireDate:dd/MM/yy}.");

             /*
             Console.WriteLine($"{harry.name} has {harry.children.Count} children.");
             Console.WriteLine($"{mary.name} has {mary.children.Count} children.");
             Console.WriteLine($"{jill.name} has {jill.children.Count} children.");
             */
        }
    }
}
