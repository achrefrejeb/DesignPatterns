namespace StrategyPattern
{
    public class SeigneurDeLaGuerre
    {
        private IStrategy _strategy;

        public IStrategy Strategy
        {
            set { _strategy = value; }
        }

        public void PrendreLaVille()
        {
            _strategy.MettreEnOeuvre();
        }
    }
}
