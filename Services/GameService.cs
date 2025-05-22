using DominionCollapse.Models;
using DominionCollapse.Models.Events;

namespace DominionCollapse.Services
{
    public class GameService
    {
        public GameState State { get; private set; } = new();

        public void AdvanceDay()
        {
            State.Day++;
            State.Nation.Tick();
            State.PlayerCorp.Tick();

            State.ActiveEvent = State.Day % 3 == 0 ? EventManager.GetRandomEvent() : null;
        }
    }
}
