namespace ConsoleApp1
{
    public class GameData
    {
        public int Currency = 0;
        public int Age = 18;
        public int CurrentCapacity = 0;
        public int TotalShipCapacity = 10000;
        public string ShipLocation = "Voliv";
        public int TravelCounter = 1;

        public GameData()
        {}

        public GameData(int currency, int age, int currentCapacity, int totalShipCapacity, string shipLocation, int travelCounter)
        {
            this.Currency = currency;
            this.Age = age;
            this.CurrentCapacity = currentCapacity;
            this.TotalShipCapacity = totalShipCapacity;
            this.ShipLocation = shipLocation;
            this.TravelCounter = travelCounter;
        }
    }
}