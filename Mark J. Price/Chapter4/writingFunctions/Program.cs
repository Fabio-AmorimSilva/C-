using System;
using static System.Console;

namespace writingFunctions
{
    class Program
    {

        static void TimeTables(byte number){

            Console.WriteLine($"This is the {number} times tables:");
            for(int row = 1; row <= 12; row++){
                Console.WriteLine($"{row} x {number} = {row * number}");

            }
            Console.WriteLine();

        }

        static void RunTimesTables(){
            bool isNumber;
            do{

                Console.WriteLine("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse( Console.ReadLine(), out byte number);

                if(isNumber){
                    TimeTables(number);

                }else {
                    Console.WriteLine("You did not enter a valid number!");

                }

            }while(isNumber);
        }


        static void Main(string[] args)
        {
            RunTimesTables();
        }

        
    }
}
