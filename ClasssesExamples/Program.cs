using System;

namespace ClassesExamples
{
    class Program
    {
        private static void Main(string[] args)
        { // variable //
            var taffy = new Candy("Orange", "Orange Saltwater Taffy", CandyType.Stretchy);

            taffy.SetRating(10);
            taffy.SetRating(5, "Just kinda liked it.");

            Console.WriteLine(taffy);
            Console.ReadLine();

        }
    }
}
