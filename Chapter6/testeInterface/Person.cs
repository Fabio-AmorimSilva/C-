using System;
using System.Collections.Generic;

namespace testeInterface
{
    public class Person : IComparable<Person>
    {
        public string name;
        public DateTime dateOfBirth;
        public List<Person>children = new List<Person>();


        public virtual void writeToConsole(){
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

        public int CompareTo(Person other){
            return name.CompareTo(other.name);
            
        }

        public override string ToString(){
            return $"{name} is a {base.ToString()}";

        }

        public void timeTravel(DateTime when){
            if(when <= dateOfBirth){
                throw new PersonException("If you travel to a date before your birth, then universe will explode.");

            }else{
                Console.WriteLine($"Welcome to {when:yyyy}");

            }
        }
    }
}