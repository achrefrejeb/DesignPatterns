using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SeigneurDeLaGuerre seigneur = new SeigneurDeLaGuerre();
            seigneur.Strategy = new AttendreQueLaVilleSeRende();

            seigneur.PrendreLaVille();

            Console.ReadLine();
        }
    }
}
