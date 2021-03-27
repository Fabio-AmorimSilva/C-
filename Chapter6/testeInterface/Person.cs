using System;
using System.Collections.Generic;

namespace testeInterface
{
    public class Person : IComparable<Person>
    {
        public string name;
        private DateTime dateOfBirth;
        public List<Person>children = new List<Person>();

        public void writeToConsole(){
            Console.WriteLine($"{this.name} was born on a {this.dateOfBirth:dddd}");


        }

        public static Person procreate(Person p1, Person p2){

            var baby = new Person{
                name = $"Baby of {p1.name} and {p2.name}"

            };

            p1.children.Add(baby);
            p2.children.Add(baby);

            return baby;

        }

        public Person procreateWith(Person partner){
            return procreate(this, partner);
            
        }

        public static Person operator *(Person p1, Person p2){
            return Person.procreate(p1, p2);

        }

        public string showName(){
            return this.name;

        }

        public int CompareTo(Person other)
        {
            return name.CompareTo(other.name);
            
        }
    }
}