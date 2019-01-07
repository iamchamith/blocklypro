using System.Collections.Generic;
using System.Threading.Tasks;
using Blockly.Core.Model;
using Microsoft.AspNetCore.Mvc;
using Blockly.Core.Service;

namespace Blockly.Api.Controllers
{
    [Route("api/game")]
    public class GameApiController : Controller
    {
        private readonly IGameService _service;

        public GameApiController(IGameService service)
        {
            _service = service;
        }

        [Route("create"), HttpPost]
        public async Task<IActionResult> CreateGame([FromBody] GameModel item)
        {
            return Ok(await _service.CreateGame(item));
        }

        [Route("get"),HttpGet]
        public async Task<IActionResult> GetGames()
        {
            return Ok(await _service.GetGames());
        }

        [Route("map/{id:int}"), HttpPost]
        public async Task<IActionResult> SaveGameMap(int id,[FromBody] List<GameMapModel> items)
        {
            var request = new GameMapRequest();
            request.GameId = id;
            request.Maps = items;
            await _service.SaveGameMap(request);
            return Ok();
        }

        [Route("{id}/map"), HttpGet]
        public async Task<IActionResult> GetGameMap(int id)
        {
            return Ok(await _service.GetGameMap(id));
        }
    }
}
