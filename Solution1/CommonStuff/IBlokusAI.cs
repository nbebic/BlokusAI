using System;
using System.Linq;

namespace BlokusAI.CommonStuff
{
    public interface IBlokusAI
    {
        /// <summary>
        /// Validates an AI class
        /// </summary>
        /// <returns>True if the class represents the AI</returns>
        bool Validate();

        /// <summary>
        /// Activates the AI class
        /// </summary>
        /// <param name="player">1 or 2, indicating the player ID</param>
        void Activate(byte player);

        /// <summary>
        /// Preforms the move on a given grid. The AI might not be started with an empty grid
        /// </summary>
        /// <param name="grid"></param>
        /// <returns></returns>
        bool Move(CommonGrid grid);

        /// <summary>
        /// Drops all resources held by the AI
        /// </summary>
        void Deactivate();

        /// <summary>
        /// Drops all precalculations by the AI, good for debugging
        /// </summary>
        /// <param name="player">1 or 2, indicating player ID</param>
        void Restart(byte player);
    }
}