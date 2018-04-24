using System;

namespace AdapterPatter2
{
    public class PortableiPhone
    {

        public void ChargerBatterie(int volts)
        {
            Console.WriteLine("Portable iPhone en charge");
            Console.WriteLine("voltage: {0}", volts.ToString());
        }
    }


}
