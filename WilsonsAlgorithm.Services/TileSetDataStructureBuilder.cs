using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WilsonsAlgorithm.Models;

namespace WilsonsAlgorithm.Services
{
    public class TileSetDataStructureBuilder : ITileSetDataStructureBuilder
    {
        public Walker Walker { get; set; }
        readonly Random _random = new Random();

        public TileSetDataStructureBuilder()
        {
            Walker = new Walker();
        }

        public async Task<TileSetDataStructure> BuildTileSetDataStructure(int horizontalLength, int verticalLength)
        {
            TileSet MazeGrid = new TileSet();

            TileSetDataStructure tileSetDataStructure = new TileSetDataStructure
            {
                HorizontalLength = horizontalLength,
                VerticalLength = verticalLength
            };

            while (MazeGrid.Tiles.Count <= 100)
            {
                await Walker.Walk(GetStartPosition(verticalLength - 1, horizontalLength - 1));

                TileSet newPath = await Walker.CreatePath();

                MazeGrid.Tiles.AddRange(newPath.Tiles);
            }

            MazeGrid.Tiles.Sort();
            tileSetDataStructure.TileSet = MazeGrid;

            return tileSetDataStructure;

        }

        private Coordinate GetStartPosition(int maxVertical, int maxHorizontal)
        {

            Coordinate startCoordinate = new()
            {
                X = _random.Next(maxHorizontal),
                Y = _random.Next(maxVertical)
            };

            return startCoordinate;
        }
    }
}
