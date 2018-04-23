using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatter2
{
    class Program
    {
        static void Main(string[] args)
        {
            Chargeur chargeur = new Chargeur();

            PortableSamsung samsung = new PortableSamsung();
            SamsungAdapter samsungAdapter = new SamsungAdapter(samsung);

            chargeur.BrancherPortable(samsungAdapter);

            Console.WriteLine("/************************************************************/");

            //PortableiPhone iPhone = new PortableiPhone();
            //iPhoneAdapter iPhoneAdapter = new iPhoneAdapter(iPhone);

            //chargeur.BrancherPortable(iPhoneAdapter);

            //Console.WriteLine("/************************************************************/");

            Console.ReadLine();

        }
    }
}
