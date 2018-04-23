namespace AdapterPatter2
{
    public class IPhoneAdapter : IChargeable
    {
        private PortableiPhone _portable;

        public IPhoneAdapter(PortableiPhone telephone)
        {
            _portable = telephone;
        }

        public void Recharger(int volts)
        {
            this._portable.ChargerBatterie(volts);
        }
    }


}
