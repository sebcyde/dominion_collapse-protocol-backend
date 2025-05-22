namespace DominionCollapse.Models
{
    public class Nation
    {
        public double GDP { get; set; } = 1000;
        public double Unrest { get; set; } = 5;
        public double PublicOpinion { get; set; } = 50;

        public void Tick()
        {
            GDP += Random.Shared.NextDouble() * 10 - 5;
            Unrest += Random.Shared.NextDouble() * 2 - 1;
            PublicOpinion += Random.Shared.NextDouble() * 2 - 1;
        }
    }
}
