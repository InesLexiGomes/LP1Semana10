using System;

namespace GuessTheNumber
{
    public class Model
    {
        public int TargetNumber{get; set;}
        public bool GuessedCorrectly{get; set;}
        public int Attempts{get; set;}
        public Model()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            TargetNumber = random.Next(1, 101);
            GuessedCorrectly = false;
            Attempts = 0;
        }
    }
}