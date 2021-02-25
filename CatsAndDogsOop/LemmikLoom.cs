using System;
using System.Collections.Generic;
using System.Text;

namespace CatsAndDogsOop
{
    class LemmikLoom
    {
        public string nimi;
        public string v2rv;
        public int LevelOfHappiness;
        public void PrintInfo() 
        {
            Console.WriteLine($"Name: {nimi}, V2rv: {v2rv},Happiness {LevelOfHappiness}");
        }
    }
}
