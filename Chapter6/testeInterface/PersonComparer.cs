using System.Collections.Generic;

namespace testeInterface
{
    public class PersonComparer : IComparer<Person>
    {
        //Compare the name lenghts...
        public int Compare(Person x, Person y)
        {
            int result = x.name.Length.CompareTo(y.name.Length);
            if(result == 0){
                return x.name.CompareTo(y.name);

            }else {
                return result;
                
            }
        }
    }
}