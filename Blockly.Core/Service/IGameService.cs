using System.Collections.Generic;
using System.Threading.Tasks;
using Blockly.Core.Model;

namespace Blockly.Core.Service
{
    public interface IGameService
    {
        Task<GameModel> CreateGame(GameModel item);
        Task<List<KeyValuePair<int,string>>> GetGames();
        Task SaveGameMap(GameMapRequest items);
        Task<List<GameMapModel>> GetGameMap(int item);
    }
}
