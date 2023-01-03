using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilsonsAlgorithm.Models
{
    public class Walker
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
        public Task Step(Coordinate newPosition)
        {
            PreviousPosition = CurrentPosition;
            CurrentPosition = newPosition;

            return Task.FromResult($"Moved to X: {CurrentPosition.X} , Y: {CurrentPosition.Y}");
        }

        /// <summary>
        /// A Task which must take a Tile as argument, which is then used to generate coords for the next tile
        /// </summary>
        /// <param name="startTile"></param>
        /// <returns>
        /// Task Result with a TileSet for the specific walk
        /// </returns>
        public Task<TileSet> Walk(Tile startTile)
        {

        }

        /// <summary>
        /// A Task which must take a TileSet as argument and create a new TileSet with the new path
        /// </summary>
        /// <returns>
        /// Task Result with a TileSet for new path
        /// </returns>
        public Task<TileSet> CreatePath(TileSet randomWalk)
        {

        }
    }
}
