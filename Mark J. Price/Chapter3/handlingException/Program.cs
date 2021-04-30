using System;

namespace handlingException
{
    class Program
    {
        static void Main(string[] args)
        {
            try{

                int number1, number2;
                Console.WriteLine("Digite um número entre 0 and 255: ");
                number1 = int.Parse(Console.ReadLine());
                while(number1 < 0 || number1 > 255){
                    Console.WriteLine("Digite um número entre 0 and 255 ou -1 para sair: ");
                    number1 = int.Parse(Console.ReadLine());
                    if(number1 == -1){
                        return;
                    }

                }

                Console.WriteLine("Digite outro número entre 0 and 255: ");
                number2 = int.Parse(Console.ReadLine());
                while(number2 < 0 || number2 > 255){
                    Console.WriteLine("Digite outro número que esteja entre 0 and 255 ou -1 para sair: ");
                    number2 = int.Parse(Console.ReadLine());
                     if(number2 == -1){
                        return;
                    }
                }

                Console.WriteLine($"{number1} divided by {number2} is {number1/number2}");


            }catch(Exception ex){
                Console.WriteLine($"{ex.GetType()}: {ex.Message}");

            }
        }
    }
}
