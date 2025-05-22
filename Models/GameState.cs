
using DominionCollapse.Models.Events;

namespace DominionCollapse.Models
{
    public class GameState
    {
        public int Day { get; set; } = 1;
        public Nation Nation { get; set; } = new();
        public Corporation PlayerCorp { get; set; } = new();
        public GameEvent? ActiveEvent { get; set; }
    }
}
