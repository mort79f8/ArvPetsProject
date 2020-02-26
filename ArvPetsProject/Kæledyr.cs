using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvPetsProject
{
    public class Kæledyr
    {
        private string navn;
        private string race;
        private int age;

        public Kæledyr(string navn, string race, int age)
        {
            Navn = navn;
            Race = race;
            Age = age;
        }

        public string Navn { get => navn; set => navn = value; }
        public string Race { get => race; set => race = value; }
        public int Age { get => age; set => age = value; }

        public virtual int HentAlder()
        {
            return Age;
        }

        public void FældHår()
        {
            Console.WriteLine($"{Navn} har smidt hår over det hele! gud hvor den fælder");
        }

        public virtual void SigNoget()
        { 
        }

        public override string ToString()
        {
            string info = $"Navn: {Navn}\n" +
                $"Race: {Race}\nAlder: {Age}";
            return info;
        }
    }
}
