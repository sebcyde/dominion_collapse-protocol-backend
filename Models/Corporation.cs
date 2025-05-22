namespace DominionCollapse.Models
{
    public class Corporation
    {
        public string Name { get; set; } = "Dominion Inc.";
        public double Funds { get; set; } = 1000000;
        public bool IsActive{ get; set; } = true;


        public void Tick()
        {
            Funds += 10000; // simple passive income
        }

        public void TriggerBankruptcy()
        {
            IsActive = false; 
        }

    }
}
