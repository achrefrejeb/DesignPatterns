namespace AdapterPatter2
{
    public class SamsungAdapter : IChargeable
    {
        private PortableSamsung _portable;

        public SamsungAdapter(PortableSamsung telephone)
        {
            _portable = telephone;
        }

        public void Recharger(int volts)
        {
            this._portable.ChargerPortable(volts > 5 ? 5 : volts);
        }
    }


}
