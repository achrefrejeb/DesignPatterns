using System;

namespace StrategyPattern
{
    public class AttendreQueLaVilleSeRende : IStrategy
    {
        public void MettreEnOeuvre()
        {
            Console.WriteLine("Attendre qu'il n'y ait plus rien à manger en ville "
                              + "et que tout le monde meure de faim.");
        }
    }
}
