using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilsonsAlgorithm.Models
{
    internal class Walker
    {
        public Coordinate? CurrentPosition { get; set; }
        public Coordinate? PreviousPosition { get; set; }

        /// <summary>
        /// A Task which must take a Coordinate as argument
        /// The walkers previous and current positions are updated
        /// </summary>
        /// <param name="newPosition"></param>
        /// <returns>
        /// The current position after update
        /// </returns>
        public Task Walk(Coordinate newPosition)
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = newPosition;

            return Task.FromResult($"Moved to X: {CurrentPosition.X} , Y: {CurrentPosition.Y}");
        }
    }
}
