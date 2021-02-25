using System;

namespace CatsAndDogsOop
{
    class Program
    {
        static void Main(string[] args)
        {
            Koer doggo = new Koer("Rex","pruun");
            Kass Kitty = new Kass("Catto","White");
            for (int i = 0; i < 10; i++)
            {
                doggo.WaveTail();
            }
            if (doggo.Bark())
            {
                Kitty.HearTheDog();
            }
            doggo.PrintInfo();
            Kitty.PrintInfo();
        }
    }
}
