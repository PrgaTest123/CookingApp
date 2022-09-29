using System;

namespace CookingApp
{
    class Lasagna
    {
        private int ExpectedCookTimeInMinuts = 40;
        private int MinutesPerLayer = 2;

        public int ExpectedMinutesInOven() => ExpectedCookTimeInMinuts;

        public int RemainingMinutesInOven(int min) => ExpectedMinutesInOven() - min;
        public int PreparationTimeInMinutes(int layers) => MinutesPerLayer * layers;
        public int ElapsedTimeInMinutes(int numberOfLayers, int numberOfMinutes) => PreparationTimeInMinutes(numberOfLayers) + numberOfMinutes;


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var lasagna = new Lasagna();

           Console.WriteLine( lasagna.ExpectedMinutesInOven());
            Console.WriteLine(lasagna.RemainingMinutesInOven(30));
            Console.WriteLine(lasagna.PreparationTimeInMinutes(2));
            Console.WriteLine(lasagna.ElapsedTimeInMinutes(3, 20));
        }

      




    }

    
}
