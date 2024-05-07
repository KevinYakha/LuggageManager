namespace LuggageManager
{
    public class LuggageFacade
    {
        private Airport startingAirport;
        private Airplane airplane;
        private Airport destinationAirport;
        private Hotel hotel;

        public LuggageFacade()
        {
            startingAirport = new Airport();
            airplane = new Airplane();
            destinationAirport = new Airport();
            hotel = new Hotel();
        }

        public void sendLuggage()
        {
            startingAirport.takeLuggage();
            startingAirport.giveLuggage();
            airplane.stowLuggage();
            airplane.unloadLuggage();
            destinationAirport.takeLuggage();
            destinationAirport.giveLuggage();
            hotel.receiveLuggage();
            hotel.giveLuggage();
        }
    }
}
