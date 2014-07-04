using System;

namespace BlokusAI.CommonStuff
{
    public class IllegalMoveException : Exception
    {
        public IllegalMoveException()
        { }
        public IllegalMoveException(string message) : base (message)
        { }
    }
}