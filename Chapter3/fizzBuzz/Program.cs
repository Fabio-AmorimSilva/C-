using System;

namespace fizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            int num;

            Console.WriteLine("FizzBuzz Game");
            Console.WriteLine("Digite um número para ser o final do intervalo:");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++){
                if(i % 3 == 0 && i > 0 && i % 5 != 0){
                    Console.WriteLine("Fizz");

                }

                if(i % 5 == 0 && i > 0 && i % 3 != 0){
                    Console.WriteLine("Buzz");

                }

                if((i % 3 == 0 && i > 0) && (i % 5 == 0 && i > 0)){
                    Console.WriteLine("FizzBuzz");

                }
            }


        }
    }
}
