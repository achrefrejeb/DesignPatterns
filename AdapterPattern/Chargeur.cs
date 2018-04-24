using System;

namespace AdapterPatter2
{
    public class Chargeur
    {
        private IChargeable _telephone;

        private const int _volts = 10;

        public void BrancherPortable(IChargeable portable)
        {
            Console.WriteLine("branchement d'un portable");
            this._telephone = portable;
            this._telephone.Recharger(_volts);
        }
    }


}
