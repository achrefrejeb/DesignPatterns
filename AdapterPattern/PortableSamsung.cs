using System;

namespace AdapterPatter2
{
    public class PortableSamsung
    {

        public void ChargerPortable(int volts)
        {
            Console.WriteLine("Portable Samsoung en charge");
            Console.WriteLine("voltage: {0}", volts.ToString());
        }
    }


}
