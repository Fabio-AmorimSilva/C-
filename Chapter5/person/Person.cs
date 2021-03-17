using System;
using System.Collections.Generic;

namespace person
{
    public class Person : object
    {
        public string name;
        public DateTime dateOfBirth;

        public WondersOfAncientWorld FavoriteAncientWonder;

        public List<Person> children = new List<Person>();
        
        public readonly string homePlanet = "Earth";
        public readonly string species = "Homo Sapiens";

        //Returns multiple values via tuple
        public (string name, DateTime birth) getNameBirth(){
            return(name: this.name, birth: this.dateOfBirth);

        }
    }
}