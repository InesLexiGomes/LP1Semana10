using System;

namespace GuessTheNumber
{
    public interface IView
    {
        void Instructions();
        bool GuessCorrectly();
        void Thank();
    }
}