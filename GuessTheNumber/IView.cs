using System;

namespace GuessTheNumber
{
    public interface IView
    {
        void Instructions();
        bool GuessCorrectly(int attempts);
        void Thank();
        int Guess();
        void TooHigh();
        void TooLow();
    }
}