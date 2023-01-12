using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilsonsAlgorithm.Models
{
    public class Tile
    {
        public Coordinate Coordinate { get; set; }

        // Property to determine if the tile is part of a random walk in progress
        public bool IsTemp { get; set; }

        public Direction? EntranceDirection { get; set; }
        public Direction? ExitDirection { get; set; }

        // Walls defined by index clockwise (0 = N, 1 = E, 2 = S, 3 = W)
        public bool[]? Walls { get; set; }

        public Task SetWalls()
        {

        }
    }
}
