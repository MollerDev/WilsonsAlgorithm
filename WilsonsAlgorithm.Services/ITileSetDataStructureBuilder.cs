using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WilsonsAlgorithm.Models;

namespace WilsonsAlgorithm.Services
{
    public interface ITileSetDataStructureBuilder
    {
        public Task<TileSetDataStructure> BuildTileSetDataStructure(int horizontalLength, int verticalLength);
    }
}
