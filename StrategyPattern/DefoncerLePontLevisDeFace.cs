using System;

namespace StrategyPattern
{
    public class DefoncerLePontLevisDeFace : IStrategy
    {
        public void MettreEnOeuvre()
        {
            Console.WriteLine("Prendre la ville de face en défonçant le pont-levis.");
        }
    }
}
