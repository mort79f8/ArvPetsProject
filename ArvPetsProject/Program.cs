using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPetsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kæledyr> kæledyr = new List<Kæledyr>();
            
            kæledyr.Add(new Kat("Princess", "Perser", 6));
            kæledyr.Add(new Kat("Prince", "Bengalkat", 3));
            kæledyr.Add(new Kat("Albert", "Sphynx", 2));
            kæledyr.Add(new Hund("Fido", "Pomeranian", 2, 1234));
            kæledyr.Add(new Hund("Rolf", "GadeKryds", 3, 2134));
            kæledyr.Add(new Hund("Bob", "Beagle", 4, 4321));

            foreach (Kæledyr dyr in kæledyr)
            {
                Console.WriteLine(dyr);
            }

            Console.WriteLine("Tryk Enter for at forsætte..");
            Console.ReadLine();
            Console.Clear();

            foreach (var dyr in kæledyr)
            {
                if (dyr is Hund)
                {
                    Hund tempdyr = (Hund)dyr;
                    tempdyr.BidPostbud();
                }
                else
                {
                    Kat tempDyr = (Kat)dyr;
                    tempDyr.KradsSofa();
                }
            }
        }
    }
}
