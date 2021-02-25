using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogsOop
{
    class Kass : LemmikLoom
    {
        public Kass(string nimi, string v2rv)
        {
            this.nimi = nimi;
            this.v2rv = v2rv;
            LevelOfHappiness = 10;
        }
        public void HearTheDog() 
        {
            LevelOfHappiness = 0;
            Hiss();
        }
        public void Hiss()
        {
            Console.WriteLine("hissssss");
        }
    }
}
