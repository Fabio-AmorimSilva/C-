using System;

namespace testeInterface
{
    public class Employee : Person
    {

        public string employeeCode{get; set;}
        public DateTime hireDate{get; set;}

        public override void writeToConsole(){
            Console.WriteLine(format: "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            arg0: name,
            arg1: dateOfBirth,
            arg2: hireDate);

        }

        public override string ToString(){
            return $"{name} and his code {employeeCode}";
            
        }

        /* Cria um novo método com o mesmo nome de métodos herdados sem o uso de override
        public new void writeToConsole(){
            Console.WriteLine(format: "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            arg0: name,
            arg1: dateOfBirth,
            arg2: hireDate);

        }
        */


        /* Cria um novo método com o mesmo nome de métodos herdados sem o uso de override
        public new void writeToConsole(){
            Console.WriteLine(format: "{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}",
            arg0: name,
            arg1: dateOfBirth,
            arg2: hireDate);

        }
        */
        
    }
}