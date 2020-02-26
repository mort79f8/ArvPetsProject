using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPetsProject
{
    public class Kat : Kæledyr
    {
        public Kat(string navn, string race, int age) : base(navn, race, age)
        {
        }

        public override void SigNoget()
        {
            Console.WriteLine("Miav");
        }

        public void KradsSofa()
        {
            Console.WriteLine($"{ Navn } flår sofaen fra hianden! du skal hvis ud og købe en ny!!");
        }
    }
}
