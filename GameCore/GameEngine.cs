using DominionCollapse.GameCore;
using DominionCollapse.Models;
using DominionCollapse.Models.Events;

namespace DominionCollapse.GameCore
{
    public static class GameEngine
    {
        private static GameState _state = GameStateFactory.CreateNew();

        public static GameState GetState()
        {
            return _state;
        }

        public static GameState AdvanceDay()
        {
            _state.Day++;
            GenerateEvent();
            ApplyDailyChanges();
            return _state;
        }

        public static GameState ApplyEventOption(int optionIndex)
        {
            if (_state.ActiveEvent == null || optionIndex < 0 || optionIndex >= _state.ActiveEvent.Options.Count)
                return _state;

            var option = _state.ActiveEvent.Options[optionIndex];

            _state.PlayerCorp.Funds -= option.Cost;

            if (option.Effects != null)
            {
                foreach (var effect in option.Effects)
                {
                    switch (effect.Target)
                    {
                        case "gdp":
                            _state.Nation.GDP += effect.Amount;
                            break;
                        case "unrest":
                            _state.Nation.Unrest += effect.Amount;
                            break;
                        case "opinion":
                            _state.Nation.PublicOpinion += effect.Amount;
                            break;
                    }
                }
            }

            _state.ActiveEvent = null;
            return _state;
        }

        private static void GenerateEvent()
        {
            _state.ActiveEvent = EventManager.GetRandomEvent();
        }

        private static void ApplyDailyChanges()
        {
            _state.Nation.GDP -= 0.5;
            _state.Nation.Unrest += 1;
            _state.Nation.PublicOpinion -= 0.2;
        }
    }
}
