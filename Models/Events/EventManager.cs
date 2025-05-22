using System.Text.Json;


namespace DominionCollapse.Models.Events
{
    public class EventManager
    {
        public static List<GameEvent> Events { get; private set; } = new();

        public static void LoadEvents()
        {
            var json = File.ReadAllText("Models/Events/event_data.json");
            Events = JsonSerializer.Deserialize<List<GameEvent>>(json)!;
        }

        public static GameEvent GetRandomEvent()
        {
            if (Events.Count == 0) LoadEvents();
            return Events[Random.Shared.Next(Events.Count)];
        }
    }
}
