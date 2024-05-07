namespace LuggageManager
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Airport startingAirport = new Airport();
            Airplane airplane = new Airplane();
            Airport destinationAirport = new Airport();
            Hotel hotel = new Hotel();

            startingAirport.takeLuggage();
            startingAirport.giveLuggage();
            airplane.stowLuggage();
            airplane.unloadLuggage();
            destinationAirport.takeLuggage();
            destinationAirport.giveLuggage();
            hotel.receiveLuggage();
            hotel.giveLuggage();

            Console.ReadKey();
        }
    }
}