using Microsoft.AspNetCore.Mvc;
using DominionCollapse.Services;
using DominionCollapse.Models;
using DominionCollapse.GameCore;


namespace DominionCollapse.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(GameEngine.GetState());
        }

        [HttpPost("advance")]
        public IActionResult AdvanceDay()
        {
            return Ok(GameEngine.AdvanceDay());
        }

        [HttpPost("choose")]
        public IActionResult ChooseOption([FromBody] int optionIndex)
        {
            return Ok(GameEngine.ApplyEventOption(optionIndex));
        }
    }
}
