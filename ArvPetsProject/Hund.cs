using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPetsProject
{
    public class Hund : Kæledyr
    {
        private int HundeTegnNr;

        public Hund(string navn, string race, int age, int hundeTegnNr) : base(navn, race, age)
        {
            HundeTegnNr = hundeTegnNr;
        }

        public int HundeTegnNr1 { get => HundeTegnNr; set => HundeTegnNr = value; }

        public override int HentAlder()
        {
            return Age * 7;
        }

        public override void SigNoget()
        {
            Console.WriteLine("Wow");
        }

        public void BidPostbud()
        {
            SigNoget();
            Console.WriteLine($"{ Navn } har fat i postbudet igen!, sikke en luns den har taget af postbudets bukser");
        }

        public override string ToString()
        {
            return base.ToString() + $"\nAlder i hunde år: {HentAlder()}\nHunde Tegn Nummer: {HundeTegnNr}";
        }

    }
}
