using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilsonsAlgorithm.Models
{
    public class TileSet
    {
        public List<Tile> Tiles { get; private set; }

        /// <summary>
        /// A Task which must take a Tile as argument
        /// If the Tile exists it is updated else it is added to the list
        /// </summary>
        /// <param name="tile"></param>
        /// <returns>
        /// A Task result with the action it took
        /// </returns>
        public Task AddTile(Tile tile)
        {
            try
            {
                Tile? currentTile = Tiles.FirstOrDefault(t =>
                    t.Coordinate.X == tile.Coordinate.X && t.Coordinate.Y == tile.Coordinate.Y);

                if (currentTile == null)
                {
                    Tiles.Add(tile);
                    return Task.FromResult("Tile Added");
                }

                else
                {
                    int tileIndex = Tiles.IndexOf(tile);
                    Tiles[tileIndex] = tile;
                    return Task.FromResult("Tile Updated");
                }
            }

            catch (Exception e)
            {
                return Task.FromException(e);
            }
        }
    }
}
