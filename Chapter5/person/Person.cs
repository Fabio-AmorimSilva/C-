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
        
    }
}