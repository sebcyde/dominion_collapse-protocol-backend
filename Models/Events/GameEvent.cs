namespace DominionCollapse.Models.Events
{
    public class GameEvent
    {
        public string Id { get; set; } = "";
        public string Description { get; set; } = "";
        public List<EventOption> Options { get; set; } = new();
    }

    public class EventOption
    {
        public string Label { get; set; } = "";
        public double Cost { get; set; }

        public List<EventEffect> Effects { get; set; } = new(); // ✅ NEW
    }

    public class EventEffect
    {
        public string Target { get; set; } = "";  // e.g. "gdp", "unrest", "opinion"
        public double Amount { get; set; }        // e.g. -10, +5
    }
}
