using System;

namespace Hacked
{
    class Program : Game
    {
        static void Main(string[] args)
        {
            Game hacked = new Game();
            hacked.Greet();
            while (hacked.DidLose() || hacked.DidWin() == !true)
            {
                hacked.Display();
                hacked.Ask();

                if (hacked.DidLose() == true)
                {
                    hacked.Display();
                    Console.WriteLine("Oh no, you've been hacked! Game over.");
                    break;
                }
                else if (hacked.DidWin() == true)
                {
                    Console.WriteLine("Congratulations, you found the word and stopped the hacking sequence!");
                    break;
                }
            }
        }
    }
}