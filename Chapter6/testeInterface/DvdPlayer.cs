using System;

namespace testeInterface
{
    public class DvdPlayer : IPlayable
    {
        public void pause()
        {
            Console.WriteLine("Dvd player is pausing...");

        }

        public void play()
        {
            Console.WriteLine("Dvd player started to play...");

        }

        public void stop(){

        }
    }
}