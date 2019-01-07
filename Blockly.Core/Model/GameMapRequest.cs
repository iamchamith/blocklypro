using System.Collections.Generic;

namespace Blockly.Core.Model
{
    public class GameMapRequest
    {
        public int GameId { get; set; }
        public List<GameMapModel> Maps { get; set; }
    }
}
