using System;

namespace testeInterface
{
    public interface IPlayable
    {
         void play();
         void pause();

         void stop(){
             Console.WriteLine("Default implementation of stop.");
             
         }
    }
}