using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExamples
{
    class Candy
    {
        //Properties
        public string Flavor { get; set; }
        public int Rating { get; private set; }
        public string Review { get; private set; }
        public string Name { get; set; }
        public CandyType Type { get; }

        //Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        //Constructor
        public Candy(string flavor, string name, CandyType type)
        {
            Flavor = flavor;
            Name = name;
            Type = type;
        }

        //Methods
        public void SetRating(int userRating)
        {
            //needs to be between 1-10 //

            if(userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"you are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}. You moron.");
            }

        }

        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        public void SetRating(bool likedIt) => Rating = likedIt ? 10 : 1;

        public override string ToString()
        {
            return $"this is {Type} {Name}, with a(n) {Flavor} flavor, rated {Rating} with a review of {Review}.";
        }
    }

    enum CandyType
    {
        chocolate, 
        HardCandy,
        Caramel,
        Sour,
        Stretchy, 
        Nut
    }
}
