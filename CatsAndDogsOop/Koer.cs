using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogsOop
{
    class Koer : LemmikLoom
    {
        public Koer(string nimi, string v2rv)
        {
            this.nimi = nimi;
            this.v2rv = v2rv;
            LevelOfHappiness = 0;
        }
        public void WaveTail() 
        {
            LevelOfHappiness +=1;
            if (LevelOfHappiness == 10)
            {
                Bark();
            
            }
        }
        public bool Bark() 
        {
            Console.WriteLine("woof-woof");
            return true;
        }
    }
}