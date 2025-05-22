using DominionCollapse.Models;

namespace DominionCollapse.GameCore
{
    public static class GameStateFactory
    {
        public static GameState CreateNew()
        {
            return new GameState
            {
                Day = 1,
                PlayerCorp = new Corporation
                {
                    Funds = 1000
                },
                Nation = new Nation
                {
                    GDP = 100.0,
                    Unrest = 5.0,
                    PublicOpinion = 50.0
                },
                ActiveEvent = null
            };
        }
    }
}