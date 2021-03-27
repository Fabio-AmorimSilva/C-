using System;

namespace testeInterface
{
    public class PersonException : Exception{

        public PersonException() : base(){} //Herda o construtor da classe base

        public PersonException(string message): base(message){}

        public PersonException(
            string message, Exception innerException)
            : base(message, innerException){}
        
    }
}